using Lab6new.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6new.RepresentationFactory.Interface
{
    internal interface IRepresentationFabric
    {
        public IAnimalRepresentation createAnimalRepresentation(Animal animal);
        public IContractRepresentation createContractRepresentation(Contract contract);
        public IOrganisationRepresentation createOrganisationRepresentation(Organisation organisation);
    }
}
