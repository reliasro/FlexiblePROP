using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Servicio
{
    public interface INotificacion  
    {
        public string Estado { get; set; }

        public string Saludame() {

            return "Como estan todos ustedes?";
        }
    }
}
