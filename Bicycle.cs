
class Bicycle : Vehicle
{
    public Bicycle(string brand, int speed) : base(brand, speed)
    {
    }

    public override void MakeSound()
    {
        System.Console.WriteLine(Brand + ": Zeng sesi!");
    }
}
