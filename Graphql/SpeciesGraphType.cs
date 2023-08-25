using GraphQL.Types;

using graphql_server.Model;

namespace graphql_server.Graphql
{
    internal class SpeciesGraphType : ObjectGraphType<Species>
    {
        public SpeciesGraphType()
        {
            Field<StringGraphType>("name").Resolve(context => context.Source.Name);
            Field<StringGraphType>("average_height").Resolve(context => context.Source.AverageHeight);
        }
    }
}