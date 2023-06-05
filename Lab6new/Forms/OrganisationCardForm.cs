using Lab6new.Models;
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
    public partial class OrganisationCardForm : Form
    {

        private Organisation Organisation { get; set; }
        public OrganisationCardForm(Organisation organisation)
        {
            Organisation = organisation;
            InitializeComponent();
        }

        private void OrganisationCardFormcs_Load(object sender, EventArgs e)
        {
            fullname.Text = Organisation.FullName;
            inn.Text = Organisation.Inn;
            kpp.Text = Organisation.Kpp;
            address.Text = Organisation.Address;
            type.Text = Organisation.Type;
            locality.Text = Organisation.Locality.Locality1;
            entity.Text = Organisation.Entity ? "Юридическое" : "Физической";
        }
    }
}
