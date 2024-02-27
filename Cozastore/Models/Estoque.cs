using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cozastore.Models;

[Table("Estoque")]
public class Estoque
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Display(Name = "Produto")]
    [Required(ErrorMessage = "Por favor, informe o produto")]
    public string ProdutoId { get; set; }
    [ForeignKey("ProdutoId")]
    public Produto Produto {get; set;}
    
    [Display(Name = "Tamanho")]
    [Required(ErrorMessage = "Por favor, informe o tamanho")]
    public string TamanhoId { get; set; }
    [ForeignKey("TamanhoId")]
    public Tamanho Tamanho {get; set;}

    [Display(Name = "Cor")]
    [Required(ErrorMessage = "Por favor, informe o cor")]
    public string CorId { get; set; }
    [ForeignKey("CorId")]
    public Cor Cor {get; set;}

    [Display(Name = "Preço")]
    [Column(TypeName = "decimal(10,2)")] 
    public Decimal? Preco {get; set;}

    [Display(Name = "Preço com Desconto")]
    [Column(TypeName = "decimal(10,2)")] 
    public decimal? PrecoDesconto { get; set; }

    [Display(Name = "Qtde de Estoque")]
    [Required(ErrorMessage = "Por favor, informe a qtde em Estoque")]
    public int QtdeEstoque { get; set; } = 0;
}
