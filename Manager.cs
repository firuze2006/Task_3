
class Manager : Employee
{
    public Manager(double salary) : base(salary)
    {
    }

    public override double CalculateBonus()
    {
        return GetSalary() * 0.20;
    }
}
