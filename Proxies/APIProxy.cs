using PatronProxy.Interfaces;
using PatronProxy.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronProxy.Proxies
{
    public class APIProxy : IAPI
    {
        private API _api = new API();
        public string UserName { get; set; }
        public string Request(string ruta)
        {
            bool esValido = CheckUser();
            if (!esValido) return $"{ruta} -- status code 401";
            return _api.Request(ruta);
        }

        private bool CheckUser() => UserName == "admin";
    }
}
