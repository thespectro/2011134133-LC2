using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _2011134133_ENT
{
    public class BaseDatos
    {
        public int baseDatosId { get; set; }
     
        public ICollection<Cuenta> Cuentas { get; set; }
        public ICollection<ATM> Atms { get; set; }
        public ICollection<Retiro> Retiro { get; set; }

        public BaseDatos()
        {
            Cuentas = new Collection<Cuenta>();
            Atms = new Collection<ATM>();
            Retiro = new Collection<Retiro>();

        }
        
    
    }
}
