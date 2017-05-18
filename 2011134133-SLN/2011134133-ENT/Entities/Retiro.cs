using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2011134133_ENT
{
    public class Retiro
    {
        public int retiroId { get; set; }
        public Teclado teclado { get; set; }
        public DispensadorEfectivo dispensadorEfectivo { get; set; }
        public Pantalla pantalla { get; set; }
        public BaseDatos baseDatos { get; set; }
        public int tecladoiD { get; set; }
        public int dispensadorEfectivoId { get; set; }
        public int pantallaId { get; set; }
        public int baseDatosId { get; set; }

        public ICollection<ATM> Atms { get; set; }

        public Retiro()
        {
            Atms = new Collection<ATM>();
        }
    }
}
