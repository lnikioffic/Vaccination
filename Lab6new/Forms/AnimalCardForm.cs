using Lab6new.Controllers;
using Lab6new.Models;
using Lab6new.RepresentationFactory;
using Lab6new.RepresentationFactory.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6new.Forms
{
    internal partial class AnimalCardForm : Form
    {
        private AnimalController AnimalController { get; }
        private AnimalCardRepresentation Animal { get; }
        public AnimalCardForm(AnimalController animalController, Animal animal)
        {
            AnimalController = animalController;
            Animal = animalController
                .GetAnimals(new List<Predicate<Animal>> { (x) => x.Id == animal.Id }, (x) => true)
                .Cast<AnimalCardRepresentation>()
                .First();
            InitializeComponent();
        }

        private void AnimalCardForm_Load(object sender, EventArgs e)
        {
            var animalRepProperties = Animal
                .GetType()
                .GetProperties()
                .Where(z => z.GetCustomAttributes(typeof(DisplayNameAttribute), false).Length > 0)
                .Select(z => z.GetValue(Animal))
                .ToList();

            var animalRepAttr = Animal
                .GetType()
                .GetProperties()
                .Select(z => z.GetCustomAttributes(typeof(DisplayNameAttribute), false))
                .Where(z => z.Length > 0)
                .Select(z => z[0])
                .Cast<DisplayNameAttribute>()
                .ToList();

            for (int i = 0; i < animalRepProperties.Count; i++)
            {
                Control control = null;
                switch (animalRepAttr[i].DisplayName)
                {
                    case "Фото":
                        {
                            animalPhoto.Image = new Bitmap(@"" + animalRepProperties[i]?.ToString());
                            break;
                        }
                    case "Животное":
                        {
                            control = new ComboBox
                            {
                                Name = "category",
                                DataSource = new List<string> { "собака", "кошка" },
                                SelectedItem = animalRepProperties.ToString(),
                                AutoSize = true
                            };
                            break;
                        }
                    case "Пол":
                        {
                            control =
                            new ComboBox
                            {
                                Name = "sex",
                                DataSource = new List<string> { "самец", "самка" },
                                SelectedItem = animalRepProperties.ToString(),
                                AutoSize = true
                            };
                            break;
                        }
                    default:
                        {
                            control = new TextBox
                            {
                                Name = "textBox" + i,
                                Text = animalRepProperties[i]?.ToString(),
                                AutoSize = true,
                            };
                            break;
                        }
                }
                if(animalRepAttr[i].DisplayName != "Фото")
                {
                    dataTable.Controls.Add(
                    new Label { Name = "label" + i, Text = animalRepAttr[i].DisplayName, AutoSize = true, },
                    0, i
                    );
                    dataTable.Controls.Add(control,1, i);
                }
            }
        }
    }
}
