using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2011134133_ENT
{
    public class Teclado
    {
        public int tecladoId { get; set; }
        public int retiroId { get; set; }

        public ICollection<ATM> Atms { get; set; }
        public ICollection<Retiro> Retiros { get; set; }

        public Teclado()
        {
            Atms = new Collection<ATM>();
            Retiros = new Collection<Retiro>();
        }
    }
}
