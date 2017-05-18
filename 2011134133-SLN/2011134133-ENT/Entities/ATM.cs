using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace _2011134133_ENT
{
    public class ATM
    {
       
        public int atmId { get; set; }
        public BaseDatos basedatos { get; set; }
        public string baseDatosId { get; set; }

        public RanuraDeposito ranuraDeposito { get; set; }
        public Teclado teclado { get; set; }
        public DispensadorEfectivo dispensadorEfectivo { get; set; }
        public Pantalla pantalla { get; set; }
        public Retiro retiro { get; set; }
        
        public string ranuraDepositoId { get; set; }
        public string tecladoId { get; set; }
        public decimal dispensadorEfectivoId { get; set; }
        public string pantallaId { get; set; }
        public decimal retiroId { get; set; }

    }
}
