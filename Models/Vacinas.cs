using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SiteCCZ.Models
{
    public partial class Vacinas
    {
        public Vacinas()
        {
            Animaisvacinas = new HashSet<Animaisvacinas>();
        }

        public int IdVacina { get; set; }
        [Required(ErrorMessage="Insira o nome da vacina",AllowEmptyStrings=false)]
        [StringLength(40)]
        public string Nome { get; set; }
        [Required(ErrorMessage="Insira a periodicidade da vacina",AllowEmptyStrings=false)]
        [StringLength(2)]
        public int? Periodicidade { get; set; }
        [Required(ErrorMessage="Insira o número de doses da vacina",AllowEmptyStrings=false)]
        [StringLength(2)]
        public int? Doses { get; set; }

        public virtual ICollection<Animaisvacinas> Animaisvacinas { get; set; }
    }
}
