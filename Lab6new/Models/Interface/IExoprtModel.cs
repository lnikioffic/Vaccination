using Lab6new.Controllers.Interface;
using Lab6new.RepresentationFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6new.Models.Interface
{
    internal interface IExoprtModel
    {
        IExportRepresentation CreateExportRepresintation();
    }
}
