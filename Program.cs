namespace GuessTheNumber.Interfaces;

public class Program
{
    static void Main(string[] args)
    {
        IUserInput userInput = new ConsoleUserInput();
        IUserOutput userOutput = new ConsoleUserOutput();

        //Возможное применение принципа подстановки Лисков (LSP). ConsoleUserOutput можно заменить на FileUserOutput без изменения кода.
        //IUserOutput userOutput = new FileUserOutput("log.txt");

        IGameSettings settings = new GameSettings();
        Game game = new Game(userInput, userOutput, settings);

        game.Play();
    }
}
