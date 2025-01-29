namespace Solid._04_ISP.Bad;

public interface IEmployee
{
    string Name { get; set; }
    void CalculateSalary();
    void CalculeteBenefits();
}

public class FullTimeEmployee : IEmployee
{
    public string Name { get; set; } = string.Empty;
    public void CalculateSalary()
    {
        Console.WriteLine("contract salary");
    }

    public void CalculeteBenefits()
    {
        Console.WriteLine("contract benefits");
    }
}

public class ContractEmployee : IEmployee
{
    public string Name { get; set; } = string.Empty;
    public void CalculateSalary()
    {
        Console.WriteLine("contract salary");
    }

    public void CalculeteBenefits()
    {
        Console.WriteLine("contract benefits");
    }
}