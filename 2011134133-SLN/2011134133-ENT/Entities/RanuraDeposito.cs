using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2011134133_ENT
{
    public class RanuraDeposito
    {
        public int ranuraDepositoId { get; set; }
        public ICollection<ATM> Atms { get; set; }

        public RanuraDeposito()
        {
            Atms = new Collection<ATM>();
        }

    }
}
