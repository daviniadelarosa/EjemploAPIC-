using EjemploConexionApi.DAO;
using System.Collections.Generic;


namespace EjemploConexionApi
{
    class Monumento
    {
        public int totalCount { get; set; }
        public int start { get; set; }
        public int rows { get; set; }
        public List<Faceta> facetas { get; set; }
        public List<Result> result { get; set; }
    }
}
