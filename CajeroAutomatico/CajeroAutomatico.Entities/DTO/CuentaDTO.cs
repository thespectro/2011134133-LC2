﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico.Entities.EntitiesDTO
{
    public class CuentaDTO
    {
        public int idCuenta { set; get; }
        public int NumeroCuenta { set; get; }
        public int pin { set; get; }
        public decimal saldo { set; get; }
        public int idBaseDatos { set; get; }
      
        
    }
}
