using PatronProxy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronProxy.Servicios
{
    public class API : IAPI
    {
        public string Request(string ruta)
        {
            return $"{ruta} -- status code 200";
        }
    }
}
