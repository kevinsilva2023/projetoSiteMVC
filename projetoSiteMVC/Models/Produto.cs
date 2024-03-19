using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

namespace projetoSiteMVC.Models
{
    [ Table("Produtos")]
    public class Produto
    {
        [Key] // garantindo que vai ser key
        public int ProdutoId { get; set; }

        [Required]
        [Display (Name = "Nome do Lanche")]
        [StringLength(80, MinimumLength = 10, ErrorMessage = "O Nome do Produto deve ter no mínimo 80 caracteres e no máximo 10.")]
        public string Nome { get; set; }

        [Required (ErrorMessage = "Descrição do Produto deve ser informada.")]
        [Display(Name = "Descrição do Produto")]
        [MinLength(20, ErrorMessage = "Descrição deve ter no mínimo 20 caracter.")]
        [MaxLength(200, ErrorMessage = "Descrição deve ter no mínimo 200 caracter.")]
        public string DescricaoCurta { get; set; }

        [Required(ErrorMessage = "Descrição Detalhada do Produto deve ser informada.")]
        [Display(Name = "Descrição do Produto")]
        [MinLength(20, ErrorMessage = "Descrição deve ter no mínimo 20 caracter.")]
        [MaxLength(200, ErrorMessage = "Descrição deve ter no mínimo 200 caracter.")]
        public string DescricaoDetalhada { get; set; }

        [Required(ErrorMessage = "Informe o preço do produto")]
        [Display(Name = "Preço")]
        [Column(TypeName="decimal(10,2)")]
        [Range(1,999.99, ErrorMessage = "O valor deve estar entre 1 e 999,99")]
        public decimal Preco { get; set; }

        [Display(Name = "Caminho Imagem Normal")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {1] caracter")]
        public string ImagemUrl { get; set; }

        [Display(Name = "Caminho Imagem Miniatura")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {1] caracter")]
        public string ImagemThumbnailUrl { get; set; }

        [Display(Name = "Produto Preferido")]
        public bool ProdutoPreferido { get; set; }

        [Display(Name = "Estoque")]
        public bool EmEstoque { get; set; }


        // propriedade de navegação (relacionamento)

        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }

    }
}
