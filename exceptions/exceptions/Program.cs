
using exceptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq; 

namespace exceptions
{ 
    class Program
    {
        static void Main()
        {
            var processor = new FileProcessor();

            var goodResults = new List<int>();
            var noFiles = new List<string>();
            var badDataFiles = new List<string>();
            var overflowFiles = new List<string>();


            for (int i = 10; i <= 29; i++)
            {
                string fileName = $"{i}.txt";
                try
                {
                    int result = processor.Process(fileName);
                    goodResults.Add(result);
                }
                catch (MyMissingFileException ex)
                {
                    noFiles.Add(ex.FileName);
                }
                catch (MyBadDataException ex)
                {
                    badDataFiles.Add(ex.FileName);
                }
                catch (MyOverflowException ex)
                {
                    overflowFiles.Add(ex.FileName);
                }
            }

            try
            {
                Console.WriteLine($"Успішно оброблено файлів: {goodResults.Count}");
                Console.WriteLine($"Середнє арифметичне: {goodResults.Average()}");
            }
            catch
            {
                Console.WriteLine("Немає даних для розрахунку середнього.");
            }

            try
            {
                WriteReport("no_file.txt", noFiles);
                WriteReport("bad_data.txt", badDataFiles);
                WriteReport("overflow.txt", overflowFiles);

                Console.WriteLine("Звіти успішно створено.");
            }
            catch (Exception)
            {
                Console.WriteLine("КРИТИЧНА ПОМИЛКА: Не вдалося створити файли звітів!");
            }

            Console.ReadLine(); 
        }

        static void WriteReport(string reportName, List<string> data) { File.WriteAllLines(reportName, data); }
    }
}