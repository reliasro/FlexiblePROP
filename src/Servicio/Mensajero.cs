using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Servicio
{
    public class Mensajero : INotificacion
    {
        public Mensajero()
        {
        }

        public string Estado { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
