using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice7
{
    public class Program
    {
        public static void Main()
        {
            Structure structure = new Structure();
            while (true)
            {
                Console.WriteLine("1 - Добавить книгу \n 2 - Добавить Журнал \n 3 - Удалить \n 4 - Получить информацию об объекте \n 5 - Получить всю информацию \n 6 - Выход");
                string switcher = Console.ReadLine()!;
                switch (switcher)
                {
                    case "1":
                        Console.WriteLine("Введите название");
                        string name = Console.ReadLine()!;
                        Console.WriteLine("Введите автора");
                        string author = Console.ReadLine()!;
                        Book book = new Book(name,author);
                        structure.Add(book);
                        break;

                    case "2":
                        Console.WriteLine("Введите название");
                        string name2 = Console.ReadLine()!;
                        Console.WriteLine("Введите автора");
                        int articles = Convert.ToInt32(Console.ReadLine()!);
                        Magazine magazine = new Magazine(name2, articles);
                        structure.Add(magazine);
                        break;

                    case "3":
                        Console.WriteLine("Введите ID");
                        int id = Convert.ToInt32(Console.ReadLine()!);
                        structure.Delete(id);
                        break;

                    case "4":
                        Console.WriteLine("Введите ID");
                        int id2 = Convert.ToInt32(Console.ReadLine()!);
                        structure.GetSingleInfo(id2);
                        break;

                    case "5":
                        structure.GetAllInfo();
                        break;

                    case "6":
                        return;
                }
            }
        }
    }
}
