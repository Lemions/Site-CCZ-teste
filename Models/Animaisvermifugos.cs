using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SiteCCZ.Models
{
    public partial class Animaisvermifugos
    {
        public int IdAnimalVermifugo { get; set; }
        public int IdAnimal { get; set; }
        public int IdVermifugo { get; set; }
        [Required(ErrorMessage="Insira a data do vermífugo",AllowEmptyStrings=false)]
        [DisplayFormat(DataFormatString = "dd/mm/yyyy")]
        public DateTime? DataVermifugo { get; set; }
        [DisplayFormat(DataFormatString = "dd/mm/yyyy")]
        public DateTime? DataProxVermifugo { get; set; }

        public virtual Animaisccz IdAnimalNavigation { get; set; }
        public virtual Vermifugos IdVermifugoNavigation { get; set; }
    }
}
