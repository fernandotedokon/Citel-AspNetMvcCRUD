using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AspNetMvcCRUD.Models
{
    [Table("Produto")]
    public class Produto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Preencha o Produto")]
        [Display(Name = "Produto")]
        [MaxLength(100)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o Preço")]
        [Display(Name = "Preço")]
        public decimal Preco { get; set; }

        [Required(ErrorMessage = "Preencha a data de cadastro")]
        [Display(Name = "Data de Cadastro")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataCadastro { get; set; } = DateTime.Today;

        public bool Ativo { get; set; } = true;

        [Required]
        [ForeignKey("Categoria")]
        public int IdCategoria { get; set; }

        public virtual Categoria Categoria { get; set; }

    }
}