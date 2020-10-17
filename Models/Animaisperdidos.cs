using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SiteCCZ.Models
{
    public partial class Animaisperdidos
    {
        public int IdAnimalPerdido { get; set; }
        [Required(ErrorMessage="Insira o nome do animal",AllowEmptyStrings=false)] 
        [StringLength(40)]
        public string Nome { get; set; }
        [Required(ErrorMessage="Insira a espécie (cão, gato, outro)",AllowEmptyStrings=false)]     
        [Display(Name = "Espécie")]
        [StringLength(10)]
        public string Especie { get; set; }
        [Display(Name = "Raça")]
        [StringLength(20)]
        public string Raca { get; set; }
        [StringLength(250)]
        public string Foto { get; set; }
        [Display(Name = "Telefone")]
        [Required(ErrorMessage="Insira seu telefone",AllowEmptyStrings=false)]
        public string TelefoneDono { get; set; }
        [Required(ErrorMessage="Acrescente detalhes sobre a ocorrência",AllowEmptyStrings=false)]
        [StringLength(200)]
        public string Detalhes { get; set; }
    }
}
