
class Car : Vehicle
{
    public Car(string brand, int speed) : base(brand, speed)
    {
    }

    public override void MakeSound()
    {
        System.Console.WriteLine(Brand + ": Bip-bip!");
    }
}
