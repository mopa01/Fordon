class Program
{
    public static void Main(){
    Fordon f = new Fordon();
    f.Namn =  "Fiat 500";
    f.Årsmodell = (1957);
    f.Tillverkare = ("Dante Giacosa");

    Fordon s = new Fordon();
    s.Namn = ("Cadillac Model A Runabout");
    s.Årsmodell = (1903);
    s.Tillverkare = ("Antonie Laumet de La Mothe");

    CarList carList = new CarList();
    Console.WriteLine("----------------------------------");
    foreach(Fordon bil in CarList)
    {
    Console.WriteLine("Namn: " + bil.Namn);
    Console.WriteLine("Årsmodell: " + bil.Årsmodell);
    Console.WriteLine("Tillverkare: " + bil.Tillverkare);
    Console.WriteLine("----------------------------------");
    }
    }
}