namespace Pokedex.Services;

    public class PokeService : IPokeService
    {

        private readonly IHttpContextAccessor _session;

        public PokeService(IHttpContextAccessor session)
        {
            _session = session;
            PopularSessao();
        }

       public Pokemon GetPokemon(int Numero);
        {
            PopularSessao();
            var pokemons = JsonSerializer.Deserialize<List<Pokemon>>(_sessio.HttpContext.Session.GetString("Pokemons"));
            return pokemons.Where(p => p.Numero == Numero).FirstOrDefault();
        }

       public List<Pokemon> GetPokemons();
        {
            PopularSessao();
            var pokemons = JsonSerializer.Deserialize<List<Pokemon>>(_sessio.HttpContext.Session.GetString("Pokemons"));
            return pokemons;

       public List<Tipo> GetTipos();
        {
            PopularSessao();
            var tipos = JsonSerializer.Deserialize<List<Tipo>>(_sessio.HttpContext.Session.GetString("Tipos"));
            return tipos;

        }
    }

    private void PopularSessao()

     if (string.IsNullOrEmpty(_sessio.HttpContext.Session.GetString("Pokemons")))
        {
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