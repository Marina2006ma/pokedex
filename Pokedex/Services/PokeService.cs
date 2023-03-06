namespace Pokedex.Services;

    public class PokeService : IPokeService
    {

        private readonly IHttpContextAccessor _session;

        public PokeService(IHttpContextAccessor session)
        {
            _session = session;
        }

        Pokemon GetPokemon(int Numero);
        {

        }

        List<Pokemon> GetPokemons();
        {

        }

        List<Tipo> GetTipos();
        {

        }
    }

    private void PopularSessao()
    {
//            ViewData["Tipos"] = JsonSerializer.Deserialize<List<Tipo>>(
//                 LerArquivo(@"Data\tipos.json")
//             );
//             var dados = LerArquivo(@"Data\pokemons.json");
//             var pokemons = JsonSerializer.Deserialize<List<Pokemon>>(dados);
                var dados = LerArquivo(@"Data\pokemons.json");
                _sessio.HttpContext.Session.SetString("Pokemons", dados);
                var dados = LerArquivo(@"Data\tipos.json");
                _sessio.HttpContext.Session.SetString("Tipos", dados);
    }


    private string LerArquivo(string nomeArquivo)
        {
            using (StreamReader leitor = new StreamReader(nomeArquivo))
            {
                string dados = leitor.ReadToEnd();
                return dados;
            }
        }