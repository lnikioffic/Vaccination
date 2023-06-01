using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6new.RepresentationFactory.Interface
{
    internal class CardRepresentationFabric : IRepresentationFabric
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
