using Lab6new.Controllers;
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
    internal partial class ContractForm : RegistriesListForm
    {
        private ContractController ContractController { get;}

        public ContractForm(ContractController contractController)
        {
            PermissionManager = contractController.PermissionManager;
            ContractController = contractController;
            InitializeComponent();
        }
    }
}
