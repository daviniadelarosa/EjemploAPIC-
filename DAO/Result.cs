using System;
namespace EjemploConexionApi.DAO
{
    class Result
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public DateTime lastUpdated { get; set; }
        public string sameAs { get; set; }
    }
}
