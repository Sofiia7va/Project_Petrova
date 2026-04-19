using System;
using System.IO;

namespace Core.Models
{
    public class ResourceManager : IDisposable
    {
        private StreamWriter writer;

        // Відкриваємо файл у конструкторі
        public ResourceManager(string fileName)
        {
            writer = new StreamWriter(fileName, true);
        }

        // Метод запису в файл
        public void WriteLog(string message)
        {
            writer.WriteLine($"{DateTime.Now}: {message}");
        }

        // Закриття ресурсу
        public void Dispose()
        {
            if (writer != null)
            {
                writer.Close();
                writer.Dispose();
                Console.WriteLine("Resource released.");
            }
        }
    }
}