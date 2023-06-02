using Lab6new.Models;
using Lab6new.RepresentationFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6new.RepresentationFactory
{
    internal class TableRepresentationFabric : IRepresentationFabric
    {
        public IAnimalRepresentation createAnimalRepresentation(Animal animal)
        {
            return new AnimalTableRepresentation(animal); ;
        }

        public IContractRepresentation createContractRepresentation(Contract contract)
        {
            throw new NotImplementedException();
        }

        public IOrganisationRepresentation createOrganisationRepresentation(Organisation organisation)
        {
            throw new NotImplementedException();
        }
    }
}
