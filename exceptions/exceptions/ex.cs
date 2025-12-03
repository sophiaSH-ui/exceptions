using System;

namespace exceptions
{
    // 1. Файлу не існує
    public class MyMissingFileException : Exception
    {
        public MyMissingFileException(string fileName) : base(fileName) { }
    }

    // 2. Файл є, але дані всередині погані (текст, дроби, мало рядків)
    public class MyBadDataException : Exception
    {
        public MyBadDataException(string fileName) : base(fileName) { }
    }

    // 3. Дані ок, але результат множення не влазить в int
    public class MyOverflowException : Exception
    {
        public MyOverflowException(string fileName) : base(fileName) { }
    }
}