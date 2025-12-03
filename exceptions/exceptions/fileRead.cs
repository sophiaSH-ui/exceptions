using System;
using System.IO;

namespace exceptions
{
    public class FileProcessor
    {
        public int Process(string fileName)
        {
            try
            {
                string[] lines = File.ReadAllLines(fileName);

                string s1 = lines[0];
                string s2 = lines[1];

                int a = int.Parse(s1);
                int b = int.Parse(s2);

                return checked(a * b);
            }
            catch (FileNotFoundException)
            {
                throw new MyMissingFileException(fileName);
            }
            catch (IndexOutOfRangeException)
            {
                throw new MyBadDataException(fileName);
            }
            catch (FormatException)
            {
                throw new MyBadDataException(fileName);
            }
            catch (OverflowException)
            {
                throw new MyOverflowException(fileName);
            }
        }
    }
}