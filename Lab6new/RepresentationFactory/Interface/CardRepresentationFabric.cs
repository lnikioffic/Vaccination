using Lab6new.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6new.RepresentationFactory.Interface
{
    internal class CardRepresentationFabric : IRepresentationFabric
    {
        public IAnimalRepresentation createAnimalRepresentation(Animal animal)
        {
            throw new NotImplementedException();
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
