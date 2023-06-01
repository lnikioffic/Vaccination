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
        public IAnimalRepresentation createAnimalRepresentation()
        {
            throw new NotImplementedException();
        }

        public IContractRepresentation createContractRepresentation()
        {
            throw new NotImplementedException();
        }

        public IOrganisationRepresentation createOrganisationRepresentation()
        {
            throw new NotImplementedException();
        }
    }
}
