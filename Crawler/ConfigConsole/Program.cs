using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ConfigConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            JsonConverter a = new BinaryConverter();
        }
    }
}
