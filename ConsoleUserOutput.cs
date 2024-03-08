using GuessTheNumber.Interfaces;

namespace GuessTheNumber
{
    public class ConsoleUserOutput : IUserOutput
    {
        public void Write(string message)
        {
            Console.WriteLine(message);
        }
    }
}
