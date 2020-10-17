using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SiteCCZ.Models
{
    public partial class Vermifugos
    {
        public Vermifugos()
        {
            Animaisvermifugos = new HashSet<Animaisvermifugos>();
        }

        public int IdVermifugo { get; set; }
        [Required(ErrorMessage="Insira o nome do vermífugo",AllowEmptyStrings=false)]
        [StringLength(40)]
        public string Nome { get; set; }
        [Required(ErrorMessage="Insira a periodicidade do vermífugo",AllowEmptyStrings=false)]
        [StringLength(2)]
        public int? Periodicidade { get; set; }

        public virtual ICollection<Animaisvermifugos> Animaisvermifugos { get; set; }
    }
}
