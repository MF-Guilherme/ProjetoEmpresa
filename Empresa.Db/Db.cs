using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Db
{
    //Helper para acesso a dados
    public static class Db
    {
        public static string Conexao //método static porque a classe é static
        {
            get
            {
                return @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=EmpresaDb;Integrated Security=True;Pooling=False";
            }
        }
    }
}
