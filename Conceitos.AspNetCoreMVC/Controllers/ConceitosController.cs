using Conceitos.AspNetCoreMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Conceitos.AspNetCoreMVC.Controllers
{
    public class ConceitosController : Controller
    {
        // Dentro de um controlle os métodos são chamados de Action
        public IActionResult Index() //interface
        {
            return View();
        }

        // Exemplos de Actions
        // 1. Action retornando uma string
        public string MostrarText()
        {
            return "Texto obtido no Controller Conceitos";
        }

        // 2. Action retornando um arquivo pdf
        public FileResult MostrarPdf()
        {
            // Parametros -> nome do arquivo, tipo de conteudo
            return File("~/pdf/Desenvolvimento Web com AspNet MVC e AspNet Core.pdf", "application/pdf");
        }

        // 3. Action retornando uma View
        public IActionResult MostrarConteudo()
        {
            return View();
        }

        // 4. Action enviando os dados de um produto para a View
        public IActionResult MostrarProduto()
        {
            Produto produto = new Produto()
            {
                Codigo = 10, Descricao = "Caixa de Som", Preco = 200
            };
            return View(produto);
        }

        // 5. Action enviado uma lista de produtos para a View
        public IActionResult MostrarLista()
        {
            return View(Informacoes.ListarProdutos());
        }
    }
}
