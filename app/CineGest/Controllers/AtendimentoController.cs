namespace CineGest.Controllers {
    public class AtendimentoController {

        private static string sala;
        private static string sessao;
        private static string filme;

        public static void SetInformacoesSessao(string salaSessao, string NrSessao, string filmeSessao) {
            sala = salaSessao;
            sessao = NrSessao;
            filme = filmeSessao;

        }

        public static string GetInformacoesSessao() {
            return $"Sessao: {sessao} | Sala: {sala} | Filme: {filme}";
        }
        public static string GetSalaSessao() {
              return sala;
        }
        public static string GetSessaoSessao() {
            return sessao;
        }
        public static string GetFilmeSessao() {
            return filme;
        }

    }
}
