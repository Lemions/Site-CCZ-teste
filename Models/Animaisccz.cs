using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SiteCCZ.Models
{
    public partial class Animaisccz
    {
        public Animaisccz()
        {
            Animaisvacinas = new HashSet<Animaisvacinas>();
            Animaisvermifugos = new HashSet<Animaisvermifugos>();
            Contatosadocao = new HashSet<Contatosadocao>();
        }

        public int IdAnimal { get; set; }
        [Required(ErrorMessage="Insira a espécie (cão, gato, outro)",AllowEmptyStrings=false)]     
        [Display(Name = "Espécie")]
        [StringLength(10)]
        public string Especie { get; set; }
        [Required(ErrorMessage="Insira o sexo do animal",AllowEmptyStrings=false)]     
        [StringLength(10)]
        public string Sexo { get; set; }
        [Required(ErrorMessage="Insira o nome do animal",AllowEmptyStrings=false)] 
        [StringLength(40)]
        public string Nome { get; set; }
        [StringLength(250)]
        public string Foto { get; set; }
        [Display(Name = "Idade aproximada")]
        [Required(ErrorMessage="Insira a idade aproximada",AllowEmptyStrings=false)]
        [StringLength(2)]
        public string IdadeAprox { get; set; }
        [Required(ErrorMessage="Insira o porte do animal",AllowEmptyStrings=false)]
        [StringLength(10)]
        public string Porte { get; set; }
        [Required(ErrorMessage="Insira a cor do animal",AllowEmptyStrings=false)]
        [StringLength(30)]
        public string Cor { get; set; }
        [Display(Name = "Raça")]
        [Required(ErrorMessage="Insira a raça do animal",AllowEmptyStrings=false)]
        public string Raca { get; set; }
        [Display(Name = "História")]
        [Required(ErrorMessage="Conte a história do animal",AllowEmptyStrings=false)]
        [StringLength(500)]
        public string Historia { get; set; }

        [Display(Name = "Status do registro")]
        [Required(ErrorMessage="Registro ativo ou arquivado?")]
        [StringLength(20)]
        public string StatusAnimal { get; set; }

        [Display(Name = "Adotável?")]
        [Required(ErrorMessage="O animal está disponível para adoção?",AllowEmptyStrings=false)]
        [StringLength(3)]
        public string Adotavel { get; set; }

        public virtual ICollection<Animaisvacinas> Animaisvacinas { get; set; }
        public virtual ICollection<Animaisvermifugos> Animaisvermifugos { get; set; }
        public virtual ICollection<Contatosadocao> Contatosadocao { get; set; }
    }
}
