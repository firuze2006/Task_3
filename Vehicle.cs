
class Vehicle
{
    public string Brand { get; set; }
    public int Speed { get; set; }

    public Vehicle(string brand, int speed)
    {
        Brand = brand;
        Speed = speed;
    }

    public virtual void MakeSound()
    {
        System.Console.WriteLine("Neqliyyat vasitesi ses cixarir.");
    }
}
