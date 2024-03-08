using GuessTheNumber.Interfaces;

namespace GuessTheNumber
{
    public class FileUserOutput : IUserOutput
    {
        private readonly string _filePath;

        public FileUserOutput(string filePath)
        {
            _filePath = filePath;
        }

        public void Write(string message)
        {
            // Примерный код записи сообщения в файл. В реальной реализации здесь может быть обработка исключений.
            File.AppendAllText(_filePath, message + Environment.NewLine);
        }
    }
}
