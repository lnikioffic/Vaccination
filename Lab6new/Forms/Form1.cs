using Lab6new.Controllers;
using Lab6new.Models;

namespace Lab6new
{
    public partial class Form1 : Form
    {
        private LocalityController localityController = new LocalityController();
        private UserController userController = new UserController();
        private OrganisationController organizationController = new OrganisationController();
        private AnimalController animalController = new AnimalController();
        public Form1()
        {
            InitializeComponent();
        }

        private void Add(object sender, EventArgs e)
        {
            /*Locality locality = new Locality { Locality1 = textBox1.Text };
            localityController.Add(locality);*/
            Predicate<Locality> h = (x) => x.Locality1 == "";
            var locality = localityController.GetData(h).First();
            var animal = new Animal
            {
                RegistrationNumber = "123",
                Category = true,
                Sex = true,
                BirthYear = 1000,
                ChipNumber = "qwe",
                Name = "qwe",
                SpecialSigns = "qwe",
                Photo = "qwe",
                Locality = locality,
            };
            animalController.Add(animal);
            //animalController.Add(animal);
            /*Organisation organisation = new Organisation
            {
                FullName = "test",
                Inn = "test",
                Kpp = "test",
                District = "test",
                City = "test",
                Street = "test",
                HouseNumber = "test",
                Index = "test",
                Type = "test",
                Entity = true,
                Locality = locality
            };
            organizationController.Add(organisation);
            User user = new User
            {
                Login = "admin",
                FirstName = "admin",
                LastName = "admin",
                Patronymic = "admin",
                Organisation = organisation,
                Role = "admin",
            };
            userController.Add(user);*/
        }

        private void Print(object sender, EventArgs e)
        {

            Predicate<Locality> h = (x) => true;
            var data = localityController.GetData(h).Select(x => x.Locality1);
            label1.Text = "";
            foreach (var item in data)
            {
                label1.Text += item.ToString() + "\n";
            }
        }

        private void Delete(object sender, EventArgs e)
        {
            Predicate<Locality> h = (x) => x.Locality1 == textBox3.Text;
            var data = localityController.GetData(h).First();
            localityController.Delete(data);
        }

        private void Update(object sender, EventArgs e)
        {
            Predicate<Locality> h = (x) => x.Locality1 == textBox2.Text;
            var data = localityController.GetData(h).First();
            data.Locality1 = textBox4.Text;
            localityController.Update(data);
        }
    }
}