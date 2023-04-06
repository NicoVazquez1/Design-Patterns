using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Observer___Weather_station.Station;
using Observer___Weather_station.Suscribers;

namespace Observer___Weather_station
{
    internal class App
    {
        public WeatherStation stationOne = new WeatherStation();

        public IObserver radio;
        public IObserver tv;
        public IObserver web;
        public void SetStationRandomData()
        {
            Random rdm = new Random();

            stationOne.TiempoActual = Nubosidad.ParcialmenteNublado;
            stationOne.Temperatura = rdm.Next(65);
            if (stationOne.Temperatura >= 40)
            {
                stationOne.Temperatura = (stationOne.Temperatura *= - 1) / 2;
            }
            stationOne.Viento = rdm.Next(80);
            stationOne.Humedad = (int)rdm.NextSingle() * 100;
        }
        public void CreateSuscribers()
        {
            radio = new Radio(stationOne);
            web = new Web(stationOne);
            tv = new TV(stationOne);
            stationOne.Attach(tv);
        }
    }
}
