using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Observer___Weather_station.Suscribers;

namespace Observer___Weather_station.Station
{
    internal interface IObservable
    {
        public void Notify();
        public void Attach(IObserver observer);
        public void Dettach(IObserver observer);

    }
}
