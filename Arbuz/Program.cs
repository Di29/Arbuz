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
            ConsoleKeyInfo inputFirst;
            ConsoleKeyInfo inputMain;

            do
            {
                firstPageInput = FirstPage();
                inputFirst = Console.ReadKey(true);
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
            } while (inputFirst.Key != ConsoleKey.Escape);

            void MainPageSwitch()
            {
                Product product;
                List<Product> listOfSection = new List<Product>();
                listOfSection.Add(product = new Product { Section = "1. Подарки" });
                listOfSection.Add(product = new Product { Section = "2. Продукты" });
                listOfSection.Add(product = new Product { Section = "3. Детские товары" });
                listOfSection.Add(product = new Product { Section = "4. Напитки" });
                listOfSection.Add(product = new Product { Section = "5. Все для дома" });
                listOfSection.Add(product = new Product { Section = "6. Товары для животных" });
                //Product product;

                do
                {
                    inputFirst = Console.ReadKey(true);
                    inputMain = Console.ReadKey(true);
                    switch (mainPageInput)
                    {
                        case (1):
                            Console.Clear();
                            foreach (var item in listOfSection)
                            {
                                Console.WriteLine(item.Section);         
                            }
                            Console.WriteLine("Назад (Q)");
                            if(inputMain.Key == ConsoleKey.Q)
                            {
                                
                            }
                            break;

                    }

                }
                while (inputFirst.Key != ConsoleKey.Escape);
            }

        }
    }
}