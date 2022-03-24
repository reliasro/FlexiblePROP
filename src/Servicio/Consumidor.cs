using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Servicio
{
    public class Consumidor 
    {
        private INotificacion _notificacion;
        public Consumidor(INotificacion Notificacion) {
            _notificacion = Notificacion;
        }
    }
}
