// See https://aka.ms/new-console-template for more information
using Observer___Weather_station;

Console.Title = "Weather station program";
int count = 0;
App app = new App();
app.CreateSuscribers();
Console.WriteLine("Resibirá actualizaciones del tiempo");
while (count < 64)
{
    Console.WriteLine("Día: " + count);
    app.SetStationRandomData();
    Console.WriteLine(app.stationOne.NotifyWeather());
    Thread.Sleep(3000);
    count++;
    Console.Clear();
    Console.Beep(); 
}
Console.WriteLine("Simulación finalizada");