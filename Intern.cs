
class Intern : Employee
{
    public Intern(double salary) : base(salary)
    {
    }

    public override double CalculateBonus()
    {
        return 100;
    }
}
