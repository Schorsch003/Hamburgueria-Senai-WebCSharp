using Hamburgueria_Senai_WebCSharp.Models;
using Hamburgueria_Senai_WebCSharp.Repositorios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hamburgueria.Controllers {
    public class PedidoController : Controller {

        private PedidoRepositorio Repositorio = new PedidoRepositorio ();

        [HttpGet]
        public IActionResult Index () {
            return View ();
        }

        [HttpPost]
        public IActionResult RegistrarPedido (IFormCollection form) {
            System.Console.WriteLine (form["nome"]);
            System.Console.WriteLine (form["endereco"]);
            System.Console.WriteLine (form["telefone"]);
            System.Console.WriteLine (form["email"]);
            System.Console.WriteLine (form["hamburguer"]);
            System.Console.WriteLine (form["shake"]);

            Pedido pedido = new Pedido ();

            Cliente cliente = new Cliente ();

            // Way 1: Most common
            cliente.Nome = form["nome"];
            cliente.Email = form["email"];
            cliente.Telefone = form["telefone"];
            cliente.Endereco = form["endereco"];

            //Way 2: Constructors
            Hamburguer hamburguer = new Hamburguer (
                Nome: form["hamburguer"]
            );

            //Way 3: Shorter version of Way 1
            Shake shake = new Shake () {
                Nome = form["shake"]
            };

            pedido.Cliente = cliente;
            pedido.Hamburguer = hamburguer;
            pedido.Shake = shake;

            Repositorio.Inserir(pedido);

            return RedirectToAction ("Index", "Home");
        }
    }
}