using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Retiros.Entities
{
    public class Movimientos
    {
        [Key]
        public int IdMovimiento { get; set; }
        public int IdCuenta { get; set; }
        public DateTime Fecha { get; set; }
        public decimal ValorRetiro { get; set; }
        public decimal ValorGmf { get; set; }
        public decimal SaldoMov { get; set; }
        public string CuentaDestino { get; set; }


    }
}
