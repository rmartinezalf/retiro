using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Retiros.Entities
{
    public class Parametros
    {
        [Key]
        public int IdParametros { get; set; }
        public string Descripcion { get; set; }
        public string Parametro { get; set; }
        public decimal Valor { get; set; }
    }
}
