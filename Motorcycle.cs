
class Motorcycle : Vehicle
{
    public Motorcycle(string brand, int speed) : base(brand, speed)
    {
    }

    public override void MakeSound()
    {
        System.Console.WriteLine(Brand + ": Vroom-vroom!");
    }
}
