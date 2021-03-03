using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Retiros.Entities
{
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }
        public string NombreCliente { get; set; }
    }
}
