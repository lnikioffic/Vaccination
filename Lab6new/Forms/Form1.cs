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
        }
    }
}