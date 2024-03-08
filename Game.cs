using GuessTheNumber.Interfaces;

namespace GuessTheNumber
{
    // Здесь мы применяем все принципы SOLID для создания гибкой и расширяемой архитектуры игры.
    public class Game
    {
        private readonly IUserInput _userInput;
        private readonly IUserOutput _userOutput;
        private readonly IGameSettings _settings;
        private readonly int _numberToGuess;

        public Game(IUserInput userInput, IUserOutput userOutput, IGameSettings settings)
        {
            _userInput = userInput; //DIP
            _userOutput = userOutput; //DIP
            _settings = settings; // DIP
            Random random = new Random();
            _numberToGuess = random.Next(_settings.NumberRangeStart, _settings.NumberRangeEnd + 1);

            _userOutput.Write($"Я загадал число от {_settings.NumberRangeStart} до {_settings.NumberRangeEnd}. Попробуйте угадать его за {_settings.MaxAttempts} попыток.");
        }

        public void Play()
        {
            for (int attempts = 0; attempts < _settings.MaxAttempts; attempts++)
            {
                int guess = _userInput.GetGuessNum(attempts + 1, _settings.MaxAttempts);
                if (guess == _numberToGuess)
                {
                    _userOutput.Write("Поздравляю! Вы угадали число!");
                    return;
                }
                else if (guess < _numberToGuess)
                {
                    _userOutput.Write("Больше!");
                }
                else
                {
                    _userOutput.Write("Меньше!");
                }
            }

            _userOutput.Write($"К сожалению, вы исчерпали все попытки. Число было {_numberToGuess}.");
        }
    }
}
