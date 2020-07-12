using Neo4j.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSMediatR.DBContext
{
    public class Neo4jDriverClient
    {
        public static IDriver Neo4jDriver { get; set; }

        public Neo4jDriverClient (string url, string username, string password)
        {
            Neo4jDriver = GraphDatabase.Driver(url, AuthTokens.Basic(username, password));
        }

        public static void Register()
        {
            Neo4jDriver = GraphDatabase.Driver("bolt://localhost:7687", AuthTokens.Basic("neo4j", "test"));
        }
    }
}
