using GraphQL.Types;

using graphql_server.Model;

namespace graphql_server.Graphql
{
    internal class CharactersGraphType : ObjectGraphType<IEnumerable<Character>>
    {
        public CharactersGraphType()
        {
            Field<IntGraphType>("count").Resolve(context => context.Source.Count());
            Field<ListGraphType<CharacterGraphType>>("characters").Resolve(context => context.Source);
        }
    }
}