using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Retiros.Entities
{
    public class Cuentas
    {
        [Key]
        public int IdCuenta { get; set; }
        public string NombreCta { get; set; }
        public string Excento { get; set; }
        public string Banco { get; set; }
        public int IdCliente { get; set; }
        public decimal Saldo { get; set; }
    }
}
