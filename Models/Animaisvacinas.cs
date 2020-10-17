using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SiteCCZ.Models
{
    public partial class Animaisvacinas
    {
        public int IdAnimalVacina { get; set; }

        public int IdAnimal { get; set; }
        public int IdVacina { get; set; }
        [Display(Name="Data da vacina")]
        [Required(ErrorMessage="Insira a data da vacina",AllowEmptyStrings=false)]
        [DisplayFormat(DataFormatString = "dd/mm/yyyy")]
        public DateTime? DataVacina { get; set; }
        [DisplayFormat(DataFormatString = "dd/mm/yyyy")]
        public DateTime? Doses { get; set; }

        public virtual Animaisccz IdAnimalNavigation { get; set; }
        public virtual Vacinas IdVacinaNavigation { get; set; }
    }
}
