using System;
using System.IO;
using Hamburgueria_Senai_WebCSharp.Models;

namespace Hamburgueria_Senai_WebCSharp.Repositorios {
    public class PedidoRepositorio {
        public bool Inserir (Pedido pedido) {
                if (!File.Exists ("Database/Pedido.csv")) {
                    var file = File.Create ("Database/Pedido.csv");
                    file.Close ();

                    var registro = $"{pedido.Id};{pedido.Cliente.Nome};{pedido.Cliente.Endereco};{pedido.Cliente.Telefone};{pedido.Cliente.Email};{pedido.Hamburguer.Nome};{pedido.Shake.Nome};{pedido.DataPedido}\n";

                    File.AppendAllText ("Database/Pedido.csv", $"{registro}");
                }
            return true;
        }
    }
}