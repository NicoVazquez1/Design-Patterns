using Observer___Weather_station.Station;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer___Weather_station.Suscribers
{
    internal class Web : IObserver
    {
        IObservable _obs;
        public Web(IObservable obs)
        {
            _obs = obs;
        }
        public void Update()
        {
            string title = "██       █████      ██     ██ ███████ ██████      ██████  ███████ ██           ██████ ██      ██ ███    ███  █████      ██████  ██████  ███    ███ \r\n██      ██   ██     ██     ██ ██      ██   ██     ██   ██ ██      ██          ██      ██      ██ ████  ████ ██   ██    ██      ██    ██ ████  ████ \r\n██      ███████     ██  █  ██ █████   ██████      ██   ██ █████   ██          ██      ██      ██ ██ ████ ██ ███████    ██      ██    ██ ██ ████ ██ \r\n██      ██   ██     ██ ███ ██ ██      ██   ██     ██   ██ ██      ██          ██      ██      ██ ██  ██  ██ ██   ██    ██      ██    ██ ██  ██  ██ \r\n███████ ██   ██      ███ ███  ███████ ██████      ██████  ███████ ███████      ██████ ███████ ██ ██      ██ ██   ██ ██  ██████  ██████  ██      ██ \r\n                                                                                                                                                   \r\n                                                                                                                                                   ";
            string msj =  $"Bienvenidos a {title}      " +
                $"{(_obs as WeatherStation).Info}";
            Console.WriteLine(msj);
        }
    }
}
