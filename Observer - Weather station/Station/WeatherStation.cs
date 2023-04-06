using Observer___Weather_station.Suscribers;
using System;


namespace Observer___Weather_station.Station
{
    public class WeatherStation : IObservable
    {
        public float Temperatura { get; set; }
        public int Humedad { get; set; }
        public int PorcentajePresipitaciones { get; set; }
        public float Viento { get; set; }
        public Nubosidad TiempoActual { get; set; }
        public string Info { get; set; }
        public string WeatherState { get; set; }

        public List<IObserver> Suscribers = new List<IObserver>();

        public void Notify()
        {
            Suscribers.ForEach(s => s.Update());
        }
        public void Attach(IObserver observer) => Suscribers.Add(observer);

        public void Dettach(IObserver observer) => Suscribers.Remove(observer);

        public string NotifyWeather()
        {
            WeatherState = $"Station one. Estado del tiempo {TiempoActual}, " +
                $"Temperatura: {Temperatura}, humedad: {Humedad}, " +
                $"Viento: {Viento} , " +
                $"Presipitationes: {PorcentajePresipitaciones} | ";

            if (Temperatura >= 29 || Temperatura <= 0)
            {
                Info = Temperatura.ToString() + "c° de Temperatura";
                WeatherState += Info;
                this.Notify();
            }
            if (Humedad >= 60)
            {
                Info = Temperatura.ToString() + "% de Humedad";
                WeatherState += Info;
                this.Notify();
            }
            if (Viento >= 80)
            {
                Info = Temperatura.ToString() + "km de Viento";
                WeatherState += Info;
                this.Notify();
            }
            if (TiempoActual == Nubosidad.Lluvia || TiempoActual == Nubosidad.Tormenta)
            {
                Info = "Actualmente el clima esta " + Temperatura.ToString();
                WeatherState += Info;
                this.Notify();
            }

            return WeatherState;
        }

    }
}

