using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbuz
{
    class Program
    {
        static public int FirstPage()
        {
            Console.Clear();
            Console.WriteLine(@"
                    1. Регистрация
                    2. Вход");

            string menu = Console.ReadLine();
            return Convert.ToInt32(menu);
        }

        static public int MainPage()
        {
            Console.Clear();
            Console.WriteLine(@"
                    1")
        }

        static void Main(string[] args)
        {
            List<User> UserList = new List<User>();
            User user = new User();

            int fPageInput = 0;
            ConsoleKeyInfo input;

            do
            {
                input = Console.ReadKey(true);
                fPageInput = FirstPage();
                switch (fPageInput)
                {
                    case (1):
                        user.UserRegistration();
                        UserList.Add(user);
                        Console.ReadLine();
                        break;
                    case (2):
                        if (user.LogIn(UserList, user))
                        {

                        }

                        break;

                }
            } while (input.Key != ConsoleKey.Escape);
            


        }
    }
}
