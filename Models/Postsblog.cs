using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SiteCCZ.Models
{
    public partial class Postsblog
    {
        public int IdPostBlog { get; set; }
        [Display(Name = "Data de publicação")]
        [DisplayFormat(DataFormatString = "dd/mm/yyyy")]
        public DateTime? DataPublicacao { get; set; }
        [Required(ErrorMessage="Insira o nome do autor")]
        [StringLength(80)]
        public string Autor { get; set; }
        [Required(ErrorMessage="O conteúdo da matéria não pode estar em branco")]
        [StringLength(2500)]
        public string Conteudo { get; set; }
        [Required(ErrorMessage="Insira uma imagem")]
        [StringLength(250)]
        public string Imagem { get; set; }
        [Display(Name = "Descrição da imagem")]
        [Required(ErrorMessage="Insira uma descrição da imagem (para problemas de conexão e leitores de tela)")]
        public string DescricaoImagem { get; set; }
    }
}
