using Microsoft.Extensions.Primitives;

namespace Hamburgueria_Senai_WebCSharp.Models {
    public class Hamburguer {
        public Hamburguer(StringValues Nome)
        {
            this.Nome = Nome;
        }

        public string Nome {get;set;}
    }
}