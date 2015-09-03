using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeITA
{
   public class SimpleFile
    {
       public string FileText { get; set; }
        public void CreateFile()
        {

            var file = new FileStream("Text.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            var writer = new StreamWriter(file);
            string text1 = "Book";
            string text2 = "Price";
            string text3 = "Text";
            string text4 = "Name";
            string text5 = "Heppy book";
            string text6 = "45";
            string text7 = "Some good story";
            string text8 = "Anton Verechaga";

            writer.WriteLine(text1 + ", " + text2 + ", " + text3 + ", " + text4 + ", " + text5 + ", " + text6 + ", " + text7 + ", " + text8);
          
            writer.Write(writer.NewLine);
           
            writer.Close();
            Console.WriteLine("Файл Text.txt создан и в него записан текст.");

            Console.WriteLine("Содержимое файла Text.txt:\n");

            StreamReader reader = File.OpenText("Text.txt");
            string input;

            while ((input = reader.ReadLine()) != null)
            {
                FileText += input;
            }
           
            Console.WriteLine(FileText);
            
            reader.Close();
            Console.ReadKey();
        }

    }
}
