using Observer___Weather_station.Station;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer___Weather_station.Suscribers
{
    internal class Radio : IObserver
    {
        IObservable _obs;
        string nombre = "San vicente";
        public Radio(IObservable obs) {
            _obs = obs;
        }
        public void Update()
        {
            string msj =  $"Desde la Radio {nombre} notificamos {(_obs as WeatherStation).Info }, bueno ya saben usen la ropa adecuada y bueno, muchachos ahora nos volvimos a ilucionar";
            Console.WriteLine(msj);
        }
    }
}
