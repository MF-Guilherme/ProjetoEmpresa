using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Models
{
    public abstract class EntidadeBase // abstract para indicar que esta é uma classe base e não poderá ser instanciada, apenas herdada por outras classes.
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }

    }
}
