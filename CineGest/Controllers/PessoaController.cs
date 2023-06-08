using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineGest.Controllers
{
    internal class PessoaController
    {
        public static List<Pessoa> GetPessoas()
        {

            using (var db = new CinegestContext())
            {

                return db.Pessoas.ToList();
            }
        }
    }
}
