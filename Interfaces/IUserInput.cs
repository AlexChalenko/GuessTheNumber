namespace GuessTheNumber.Interfaces
{
    // Принцип разделения интерфейса (Interface Segregation Principle - ISP)
    public interface IUserInput
    {
        int GetGuessNum(int attemptNum, int attemptCount);
    }
    
    public interface IUserOutput
    {
        void Write(string message);
    }
}
