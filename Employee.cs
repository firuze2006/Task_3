
abstract class Employee
{
    private double baseSalary;

    public Employee(double salary)
    {
        SetSalary(salary);
    }

    public double GetSalary()
    {
        return baseSalary;
    }

    public void SetSalary(double salary)
    {
        if (salary >= 0)
        {
            baseSalary = salary;
        }
        else
        {
            baseSalary = 0;
        }
    }

    public abstract double CalculateBonus();

    public double CalculateTotalSalary()
    {
        return GetSalary() + CalculateBonus();
    }
}
