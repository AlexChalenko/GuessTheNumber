using GuessTheNumber.Interfaces;

namespace GuessTheNumber
{
    // Принцип открытости/закрытости (Open/Closed Principle - OCP)
    // Этот класс настроек может быть расширен, но не изменен. Если нам нужно изменить настройки, мы можем создать новый класс, наследующийся от IGameSettings.
    public class GameSettings : IGameSettings
    {
        public int MaxAttempts { get; private set; } = 10;
        public int NumberRangeStart { get; private set; } = 1;
        public int NumberRangeEnd { get; private set; } = 100;
    }
}
