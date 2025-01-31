namespace Solid._05_DIP.Good;

interface IEmailService
{
    void Send();
}

public class EmailService : IEmailService
{
    public void Send()
    {
        Console.WriteLine("Sending email");
    }
}

public class FakeEmailService : IEmailService
{
    public void Send()
    {
        Console.WriteLine("Sending FAKE email");
    }
}