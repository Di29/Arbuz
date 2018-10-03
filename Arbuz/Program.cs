using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbuz
{
    class Program
    {
        static int FirstPage()
        {
            Console.Clear();
            Console.WriteLine("1. Регистрация \n2. Вход");

            string menu = Console.ReadLine();
            return Convert.ToInt32(menu);
        }

        static int MainPage()
        {
            Console.Clear();
            Console.WriteLine("1. Купить товар \n2. Корзина \n3. Покупки \n0. Выход");

            string menu = Console.ReadLine();
            return Convert.ToInt32(menu);
        }

        static void Main(string[] args)
        {
            List<User> UserList = new List<User>();
            User user = new User();

            int firstPageInput = 0;
            int mainPageInput = 0;
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
                            mainPageInput = MainPage();
                            MainPageSwitch();
                        }
                        else
                        {
                            Console.WriteLine("Логин или пароль введены не правильно");
                            Console.ReadLine();             
                        }

                        break;

                }
            } while (input.Key != ConsoleKey.Escape);

            void MainPageSwitch()
            {
                List<Product> productList = new List<Product>();
                Product product = new Product();

                do
                {
                    switch (mainPageInput)
                    {
                        case (1):
                            Console.WriteLine("1. Подарки \n2.Продукты \n3. Детские товары \n4. Напитки \n5. Все для дома \n6Товары для животных");
                            break;

                    }

                }
                while (mainPageInput != 9);
        }

        }

        



        
    }
}
