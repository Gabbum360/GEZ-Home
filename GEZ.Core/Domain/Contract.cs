using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEZ.Core.Domain
{
    public class Contract
    {
        protected Contract() { }

        public Contract(Guid id, string contractType, Address location)
        {
            Id = id;
            ContractType = contractType;
            Location = location;
        }

        public Guid Id { get; set; } 
        public string ContractType { get; private set; }    
        public Address Location { get; }

        public abstract class ContractFactory
        {
            public Contract Create(Guid id, string contractType, Address location)
            {
                return new Contract(id, contractType, location);    
            }   
        }

        /*public Contract SetContracts(string kindOfJob)
        {
            this.ContractType = kindOfJob;
            switch ()
            {
                case: if (kindOfJob ==  DSTV)
                default:
            }
            return this;
        }*/
    }
}
