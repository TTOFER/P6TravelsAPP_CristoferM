using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P6TravelsAPP_CristoferM.Services
{
    public static class WebAPIConnection
    {
        //esta clase autoinstanciada permite configurar ruta de consumo base
        //del servicio web API. Normalmente es DNS -> www.misitio.com/api/
        //o con IP -> 85.25.45.10/api o local -> 192.168.100.9/api

        //variable
        public static string BaseURl = "http://192.168.100.9:45459/api/";

        //incluir info de seguridad
        //para los end point del API

        public static string ApikeyName = "Apikey";
        public static string ApikeyRadio = "CrisDP62024abx123";

        //incluir forma de codificar paquetes JSON que seran enviados y recibidos del API

        public static string Mimetype = "application/json";
        public static string ContentType = "Content-Type";
    }
}
