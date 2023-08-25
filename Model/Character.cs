using CsvHelper.Configuration.Attributes;

namespace graphql_server.Model
{
    public class Character
    {
        [Index(0)]
        public string Name { get; set; }
    }
}