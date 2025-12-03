using System;

namespace exceptions
{
    // 1. Помилка: файлу немає
    public class MyMissingFileException : Exception
    {
        // Оце те, чого не вистачало:
        public string FileName { get; }

        public MyMissingFileException(string fileName)
        {
            FileName = fileName;
        }
    }

    // 2. Помилка: погані дані
    public class MyBadDataException : Exception
    {
        public string FileName { get; }

        public MyBadDataException(string fileName)
        {
            FileName = fileName;
        }
    }

    // 3. Помилка: переповнення
    public class MyOverflowException : Exception
    {
        public string FileName { get; }

        public MyOverflowException(string fileName)
        {
            FileName = fileName;
        }
    }
}