using GraphQL.Types;

using graphql_server.Data;

namespace graphql_server.Graphql
{
    public class MyQuery : ObjectGraphType<object>
    {
        public MyQuery(IDataService dataService)
        {
            Field<ListGraphType<SpeciesGraphType>>("species");
            Field<CharactersGraphType>("characters").Resolve(_ => dataService.GetCharacters());
        }
    }
}
