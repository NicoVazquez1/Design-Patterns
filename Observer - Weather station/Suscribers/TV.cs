using Observer___Weather_station.Station;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer___Weather_station.Suscribers
{
    internal class TV : IObserver
    {
        IObservable _obs;
        public TV(IObservable obs)
        {
            _obs = obs;
        }
        public void Update()
        {
            string msj =  $"  " +
                $"                        .-------,\r\n                     ../         \\\r\n                    /  ,   ,   ,  \\\r\n                   /  , \\__\\___\\   \\      El clima de hoy reporta\r\n                  |   | __ || __',. \\     {(_obs as WeatherStation).Info} como pueden ver a continuación \r\n                  |   \\_'_/ \\_'_/.   |    Procuren usar la ropa adecuada!.\r\n                  |  (|    v    |)   |    ---   -----\r\n                  ,    |       |    .       /\r\n                   |    \\  ~  /     |   ---'\r\n                   |   /. | | .\\    .\r\n                   / ,/ |/   \\| \\,  |,\r\n                  ( <-,  \\___/  ,->   )\r\n                   |  ,_ \\   / _,  .|\r\n                   | \\  \\ \\ / /   / |\r\n                   | |   \\ * /    | |\r\n                   | |     #      | |\r\n\r\n                                    (1/2 kl)";
            Console.WriteLine(msj);   
        }
    }
}
