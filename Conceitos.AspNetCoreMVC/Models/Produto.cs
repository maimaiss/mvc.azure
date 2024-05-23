namespace Conceitos.AspNetCoreMVC.Models
{
    public class Produto
    {
        // prop (atalho de propriedade)
        public int Codigo { get; set; }
        public string? Descricao { get; set; }
        // ? -> mostra que sabe que pode ter o valor null em strings
        public double Preco { get; set; }
    }
}
