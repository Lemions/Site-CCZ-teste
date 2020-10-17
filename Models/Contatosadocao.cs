using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SiteCCZ.Models
{
    public partial class Contatosadocao
    {
        public int IdContatoAdocao { get; set; }
        public int IdAnimal { get; set; }
        [Required(ErrorMessage="Insira seu nome",AllowEmptyStrings=false)]
        [StringLength(40)]
        public string Nome { get; set; }
        [Required(ErrorMessage="Insira seu email",AllowEmptyStrings=false)]
        [StringLength(100)]
        [RegularExpression(".+\\@.+\\..+",ErrorMessage = "Informe um email válido...")]
        public string Email { get; set; }
        [Required(ErrorMessage="Insira seu telefone",AllowEmptyStrings=false)]
        [StringLength(20)]
        public string Telefone { get; set; }
        [Required(ErrorMessage="Acrescente detalhes sobre a ocorrência",AllowEmptyStrings=false)]
        [StringLength(200)]
        public string Justificativa { get; set; }

        public virtual Animaisccz IdAnimalNavigation { get; set; }
    }
}
