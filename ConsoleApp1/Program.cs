using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<AbstractHandler>list = new List<AbstractHandler>();
            while (true) 
            {
                Console.WriteLine("Введите метку:");
                string metka = Console.ReadLine();
                switch (metka)
                {
                    case "DOC":
                    case "doc":
                        AbstractHandler doc = new DOCHandler();
                        doc.Open();
                        doc.Create();
                        doc.Change();
                        doc.Save();
                        break;


                    case "TXT":
                    case "txt":
                        AbstractHandler txt = new TXTHandler();
                        txt.Open();
                        txt.Create();
                        txt.Change();
                        txt.Save();
                        break;


                    case "XML":
                    case "xml":
                        AbstractHandler xml = new XMLHandler();
                        xml.Open();
                        xml.Create();
                        xml.Change();
                        xml.Save();
                        break;

                    case "Q":
                    case "q":return;
                        default: Console.WriteLine("Такой метки не существует");
                        break;
                }

            }




            Console.ReadKey();
        }
    }
}
