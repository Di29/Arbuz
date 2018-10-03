using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Goods;

namespace Arbuz
{
    class Program
    {
        static public int FirstPage()
        {
            Console.Clear();
            Console.WriteLine("1. Регистрация \n2. Вход");

            string menu = Console.ReadLine();
            return Convert.ToInt32(menu);
        }

        static void Main(string[] args)
        {
            List<User> UserList = new List<User>();
            User user = new User();

            int firstPageInput = 0;
            ConsoleKeyInfo input;

            do
            {
                firstPageInput = FirstPage();
                input = Console.ReadKey(true);
                switch (firstPageInput)
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

        void MainPageSwitch()
        {
            AnimalGood animalGood = new AnimalGood();
            Beverage beverage = new Beverage();
            ChildrenGood childrenGood = new ChildrenGood();
            Housing housing = new Housing();
            Present present = new Present();
            Product product = new Product();

            int mainPageInput = 0;
            do
            {
                switch (mainPageInput)
                {
                    case (1):

                }

            }
        }


        int MainPage()
        {
            Console.Clear();
            Console.WriteLine("1. Купить товар \n2. Корзина \n3. Покупки");

            string menu = Console.ReadLine();
            return Convert.ToInt32(menu);
        }
    }
}
