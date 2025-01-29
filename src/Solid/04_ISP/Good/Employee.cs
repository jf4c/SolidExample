namespace Solid._04_ISP.Good;

public interface ISalaryEmployee
{
    void CalculateSalary();
}
    
public interface IBenefitsEmployee
{
    void CalculeteBenefits();
}

public class FullTimeEmployee : ISalaryEmployee, IBenefitsEmployee
{
    public void CalculateSalary()
    {
        Console.WriteLine("contract salary");
    }

    public void CalculeteBenefits()
    {
        Console.WriteLine("contract benefits");
    }
}

public class ContractEmployee : IBenefitsEmployee
{
    public void CalculeteBenefits()
    {
        Console.WriteLine("contract benefits");
    }
}