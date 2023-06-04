﻿using Lab6new.Controllers;
using Lab6new.Models;
using Lab6new.PermissionManagers;
using Lab6new.RepresentationFactory;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6new.Forms
{
    internal partial class VaccinationForm : Form
    {
        public VaccinationForm(ActController actController, Animal animal)
        {
            ActController = actController;
            if (animal.Acts.Where((x) => x.EndDate > DateOnly.FromDateTime(DateTime.Now)).FirstOrDefault() == null)
                this.animal = animal;
            else
                throw new ArgumentException("У этого животного еще действует вакцина");
            user = ActController.User;
            startDate = DateOnly.FromDateTime(DateTime.Now);
            InitializeComponent();

        }

        public VaccinationForm(ActController actController, Animal animal, Act act)
        {
            ActController = actController;
            if (animal.Acts.Count != 0)
                this.animal = animal;
            else
                throw new ArgumentException("У этого животного нет актов для изменения");
            this.act = act;
            user = act.User;
            startDate = act.StartDate;
            InitializeComponent();
        }

        private Act? act;

        private User user;

        private Organisation Organisation { get { return user.Organisation; } }

        private Locality Locality { get { return Organisation.Locality; } }

        private DateOnly startDate;

        private Lab6new.Models.Contract Contract
        {
            get
            {
                return Organisation
                    .ContractPerformOrganisations
                    .OrderByDescending((x) => x.EndDate)
                    .First();
            }
        }

        private ActController ActController { get; }

        private Animal animal;

        private void VaccinationForm_Load(object sender, EventArgs e)
        {
            animalTextBox.Text = animal.ToString();
            userTextBox.Text = user.ToString();
            contractTextBox.Text = Contract.ToString();
            localityTextBox.Text = Locality.ToString();
            startDateTextBox.Text = startDate.ToString();
            if (act != null)
            {
                durationTextBox.Text = (act.EndDate.DayNumber - act.StartDate.DayNumber).ToString();
                serialNumbTextBox.Text = act.SerialNumber.ToString();
                typeTextBox.Text = act.Type.ToString();
                addButton.Visible = false;
                changeButton.Visible = true;
            }
            else
            {
                addButton.Visible = true;
                changeButton.Visible = false;
            }
        }

        private Act CreateAct()
        {
            var interval = new Interval(startDate, durationTextBox.Text);
            return new Act
            {
                AnimalId = animal.Id,
                UserId = user.Id,
                StartDate = interval.StartDate,
                EndDate = interval.EndDate,
                Type = typeTextBox.Text,
                SerialNumber = serialNumbTextBox.Text,
                LocalityId = Locality.Id,
                ContractId = Contract.Id
            };
        }

        private void Redirect()
        {
            this.Close();
            var card = new AnimalCardForm(
                new AnimalController(
                    ActController.PermissionManager,
                    ActController.User,
                    new CardRepresentationFabric()),
                new LocalityController(
                    ActController.PermissionManager,
                    ActController.User),
                new ActController(
                    ActController.PermissionManager,
                    ActController.User),
                animal);
            card.Show();
        }


        private void changeButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (act != null){
                    var interval = new Interval(startDate, durationTextBox.Text);
                    act.EndDate = interval.EndDate;
                    act.Type = typeTextBox.Text;
                    act.SerialNumber = serialNumbTextBox.Text;
                    ActController.Update(act);
                }
                var message = MessageBox.Show("Акт успешно изменен", "Сообщение", MessageBoxButtons.OK);
                if (message == DialogResult.OK)
                    Redirect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                var act = CreateAct();
                ActController.Add(act);
                var message = MessageBox.Show("Животное успешно вакцинировано", "Сообщение", MessageBoxButtons.OK);
                if (message == DialogResult.OK)
                    Redirect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }
    }
}