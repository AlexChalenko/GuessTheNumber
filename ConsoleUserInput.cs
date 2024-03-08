using GuessTheNumber.Interfaces;

namespace GuessTheNumber
{
    // Принцип единственной ответственности (Single Responsibility Principle - SRP)
    public class ConsoleUserInput : IUserInput
    {
        public int GetGuessNum(int attemptNum, int attemptCount)
        {
            Console.WriteLine($"Попытка #{attemptNum} из {attemptCount}. Введите ваше предположение:");
            return int.Parse(Console.ReadLine());
        }
    }
}
