using GraphQL.Types;

using graphql_server.Model;

namespace graphql_server.Graphql
{
    internal class CharacterGraphType : ObjectGraphType<Character>
    {
        public CharacterGraphType()
        {
            Field<StringGraphType>("name");
        }
    }
}