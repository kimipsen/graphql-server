using System.Globalization;

using CsvHelper;

using graphql_server.Model;

namespace graphql_server.Data
{
    public class DataService : IDataService
    {
        private List<Species> _species = new ();
        private List<Character> _characters = new ();

        public DataService()
        {
            LoadSpecies();
            LoadCharacters();
        }

        public IEnumerable<Species> GetSpecies()
        {
            return _species;
        }

        public IEnumerable<Character> GetCharacters()
        {
            return _characters;
        }


        private void LoadCharacters()
        {
            using var reader = new StreamReader("data\\characters.csv");
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            var items = csv.GetRecords<Character>();

            _characters.AddRange(items);
        }

        private void LoadSpecies()
        {
            using var reader = new StreamReader("data\\species.csv");
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            var items = csv.GetRecords<Species>();

            _species.AddRange(items);
        }
    }
}
