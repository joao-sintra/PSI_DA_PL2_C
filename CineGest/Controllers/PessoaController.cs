using System.Collections.Generic;
using System.Linq;

namespace CineGest.Controllers {
    internal class PessoaController {
        public static List<Pessoa> GetPessoas() {

            using (var db = new CinegestContext()) {

                return db.Pessoas.ToList();
            }
        }
    }
}
