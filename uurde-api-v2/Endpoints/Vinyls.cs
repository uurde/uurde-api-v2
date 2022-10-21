using Microsoft.AspNetCore.Mvc;

namespace uurde_api_v2.Endpoints
{
    public static class Vinyls
    {
        public static IEnumerable<string> List()
        {
            return new string[] { "value1", "value2" };
        }

        public static string Get(int id)
        {
            return "value";
        }

        public static void Post([FromBody] string value)
        {
        }

        public static void Put(int id, [FromBody] string value)
        {
        }

        public static void Delete(int id)
        {
        }
    }
}

