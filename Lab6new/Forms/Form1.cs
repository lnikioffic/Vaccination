using Lab6new.Controllers;
using Lab6new.Models;

namespace Lab6new
{
    public partial class Form1 : Form
    {
        /*private CRUDCardController<Locality> localityController = new CRUDCardController<Locality>();
        private CRUDCardController<User> userController = new CRUDCardController<User>();
        private CRUDCardController<Organisation> organizationController = new CRUDCardController<Organisation>();
        private CRUDCardController<Animal> animalController = new CRUDCardController<Animal>();
        private CRUDCardController<District> districtController = new CRUDCardController<District>();*/
        public Form1()
        {
            InitializeComponent();
        }

        private void Add(object sender, EventArgs e)
        {

            /*Predicate<District> h = (x) => x.District1 == "���������";
            District district = districtController.GetData(h).First();
            Locality locality = new Locality { Locality1 = "������", DistrictId = district.Id };
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
                Role = "�������� ����",
            };
            userController.Add(user);*/
            /*using Lab6new.Models;
using Lab6new.RepresentationFactory.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6new.RepresentationFactory
{
    internal class AnimalCardRepresentation : IAnimalRepresentation
    {
        [DisplayName("��������������� �����")]
        public string RegistrationNumber { get {return Animal.RegistrationNumber; } }

        [DisplayName(@"��������")]
        public string Category { get {return Animal.Category ? "������" : "�����"; } }

        [DisplayName(@"���")]
        public string Sex { get {return Animal.Sex ? "�����" : "�����"; } }

        [DisplayName(@"��� ��������")]
        public int BirthYear { get { return Animal.BirthYear; } }

        [DisplayName(@"����� ����")]
        public string ChipNumber { get {return Animal.ChipNumber; } }

        [DisplayName(@"������")]
        public string Name { get { return Animal.Name; } }

        [DisplayName(@"������ �������")]
        public string SpecialSigns { get {return Animal.SpecialSigns; } }

        [DisplayName(@"����")]
        public string Photo { get {return Animal.Photo; } }

        [DisplayName(@"��������� �����")]
        public string Locality { get {return Animal.Locality.Locality1; } }

        public Animal Animal { get; }

        public Act? lastAct { get { return Animal.Acts.OrderByDescending(x => x.EndDate).FirstOrDefault(); } }

        [DisplayName(@"���� ������")]
        public DateOnly? actStartDate { get { return lastAct?.StartDate; } }

        [DisplayName(@"���� ��������")]
        public DateOnly? actEndDate { get { return lastAct?.EndDate; } }

        [DisplayName(@"��� �������")]
        public string? actType { get { return lastAct?.Type; } }

        public AnimalCardRepresentation(Animal animal)
        {
            Animal = animal;
        }

        public void setValue(Animal animal)
        {
            throw new NotImplementedException();
        }
    }
}
*/
        }
    }
}