using graphql_server.Model;

namespace graphql_server.Data
{
    public interface IDataService
    {
        IEnumerable<Species> GetSpecies();
        IEnumerable<Character> GetCharacters();
    }
}