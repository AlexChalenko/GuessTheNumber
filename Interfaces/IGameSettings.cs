namespace GuessTheNumber.Interfaces
{
    // Принцип инверсии зависимостей (Dependency Inversion Principle - DIP)
    public interface IGameSettings
    {
        int MaxAttempts { get; }
        int NumberRangeStart { get; }
        int NumberRangeEnd { get; }
    }
}
