using Newtonsoft.Json;
using System;
using System.Text.Json.Serialization;

namespace MyMessanger_Stepik
{
    class Program
    {
        static void Main(string[] args)
        {
            Message msg = new Message("RusAl", "Privet", DateTime.UtcNow);
            string output = JsonConvert.SerializeObject(msg);
            Console.WriteLine(output);
            Message deserializedMsg = JsonConvert.DeserializeObject<Message>(output);
            Console.WriteLine(deserializedMsg);
            //{ "UserName":"RusAl","MessageText":"Privet","TimeStamp":"2023-08-18T12:32:58.2606102Z"}
            //RusAl < 18.08.2023 12:32:58 >: Privet

        }
    }
}