using System;
using System.IO;
using System.Net;
using EjemploConexionApi.DAO;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace EjemploConexionApi
{
    class Program
    {
        static void Main(string[] args)
        {
            Monumento monumento;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(@"http://www.zaragoza.es/sede/servicio/monumento.solrjson");
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                var json = reader.ReadToEnd();
                monumento = JsonConvert.DeserializeObject<Monumento>(json);
            }

            List<Result> result = monumento.result;
            Console.WriteLine();
            foreach (Result a in result)
            {
                Console.WriteLine("Monumento: " + a.title);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

        }

    }
}
