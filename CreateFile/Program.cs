using System;
using System.IO;

namespace CreateFile
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateNewFile();

            Console.WriteLine("Enter the file name (include extension) : ");
            string userInput = Console.ReadLine();
            //CreateUserFile(userInput);
            CreateFileWithExtension(userInput);
        }

        public static void CreateNewFile()
        {
            string rootPath = @"C:\Users\opilane\Samples\playerOne";
            string fileName = "ball.txt";
            File.Create(Path.Combine(rootPath, fileName));
        }

        public static void CreateUserFile(string userInput)
        {
            string rootPath = @"C:\Users\opilane\Samples\playerTwo";
            File.Create(Path.Combine(rootPath, userInput));
        }

        public static void CreateFileWithExtension(string userInput)
        {
            string rootPath = @"C:\Users\opilane\Samples\playerTwo";
            string fullfileName = $"{userInput}.txt";
            File.Create(Path.Combine(rootPath, fullfileName));
        }
    }
}
