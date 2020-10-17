using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SiteCCZ.Models
{
    public partial class Equipeccz
    {
        public int IdColaborador { get; set; }
        [Required(ErrorMessage="Insira o nome do colaborador",AllowEmptyStrings=false)]     
        [StringLength(40)]
        public string Nome { get; set; }
        [Required(ErrorMessage="Insira o cargo do colaborador",AllowEmptyStrings=false)]     
        [StringLength(20)]
        public string Cargo { get; set; }
    }
}
