using GraphQL.Types;

namespace graphql_server.Graphql
{
    public class MySchema : Schema
    {
        public MySchema(MyQuery query)
        {
            Query = query;
        }
    }
}
