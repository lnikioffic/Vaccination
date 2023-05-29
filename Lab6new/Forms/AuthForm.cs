using Lab6new.Controllers;
using Lab6new.Controllers.Interface;
using Lab6new.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6new.Forms
{
    public partial class AuthForm : Form
    {
        private CRUDCardController<Locality> localityController = new CRUDCardController<Locality>();
        private CRUDCardController<User> userController = new CRUDCardController<User>();
        private CRUDCardController<Organisation> organizationController = new CRUDCardController<Organisation>();
        private CRUDCardController<Animal> animalController = new CRUDCardController<Animal>();
        private CRUDCardController<District> districtController = new CRUDCardController<District>();
        private IAuthController authController = new AuthController();
        public AuthForm()
        {
            /*Predicate<District> h = (x) => x.District1 == "Москоский";
            District district = districtController.GetData(h).First();
            Locality locality = new Locality { Locality1 = "Москва", DistrictId = district.Id };
            localityController.Add(locality);
            Organisation organisation = new Organisation
            {
                FullName = "test",
                Inn = "test",
                Kpp = "test",
                Address = "test",
                Type = "test",
                Entity = true,
                LocalityId = locality.Id
            };
            organizationController.Add(organisation);
            User user = new User
            {
                Login = "admin",
                Password = GetHash("admin"),
                FirstName = "admin",
                LastName = "admin",
                Patronymic = "admin",
                OrganisationId = organisation.Id,
                Role = "Оператор ОМСУ",
            };
            userController.Add(user);*/
            InitializeComponent();
        }
        public string GetHash(string input)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));
            return Convert.ToBase64String(hash);
        }

        private void authButton_Click(object sender, EventArgs e)
        {
            var login = loginTextBox.Text;
            var password = passwordTextBox.Text;
            var permMan = authController.Authorization(login, password);
        }
    }
}
