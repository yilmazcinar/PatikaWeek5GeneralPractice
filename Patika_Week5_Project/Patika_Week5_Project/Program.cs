using System.Reflection.Emit;
using Patika_Week5_Project;




List<Car> cars = new List<Car>();

label:

Console.WriteLine("Araba üretmek istiyor musunuz? (e/h)");

string userInput = Console.ReadLine().ToLower().Trim();
while (userInput != "e" && userInput != "h")
{
    Console.WriteLine("Hatalı giriş E ya da H giriniz");
    userInput = Console.ReadLine().ToLower().Trim();


}

if (userInput == "e")
{
    Car car = new Car();
    Console.Write("Seri numarası: ");
    car.SerialNumber = Console.ReadLine();
    Console.Write("Marka: ");
    car.Brand = Console.ReadLine();
    Console.Write("Model: ");
    car.Model = Console.ReadLine();
    Console.Write("Renk: ");
    car.Color = Console.ReadLine();
start:
    try
    {
        Console.Write("Kapı sayısı: ");
        car.DoorNumber = Convert.ToInt32(Console.ReadLine());
    }
    catch (Exception)
    {

        Console.WriteLine("Geçersiz değer");
        goto start;
    }

    cars.Add(car);
    goto label;

}
else
{
    if (cars.Count != 0)
    {
        foreach (Car car in cars)
        {
            Console.WriteLine($"Seri Numarası: {car.SerialNumber} - Marka: {car.Brand}");
        }
    }
    else
    {
        Console.WriteLine("Listelencek araba yoktur");

    }

}


 
