using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace Arbuz
{
    public class User: ITwilio
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        Wallet wallet;

        const string _accountSid = "AC21972c77ed7f6cb6d8e53a6e91e73544";
        const string _accountToken = "216baea766b06c889b04454533e820b6";
        const int RANDOM_MIN = 0000;
        const int RANDOM_MAX = 9999;
        int _verifyCode;
        int userCode = 0;
        Random random = new Random();

        public User(string fName, string lName, string login, string password, string phoneNum, Wallet purse)
        {
            FirstName = fName;
            LastName = lName;
            Login = login;
            Password = password;
            wallet = purse;
            PhoneNumber = phoneNum;
        }

        public User()
        {
            FirstName = null;
            LastName = null;
            Login = null;
            Password = null;
            PhoneNumber = null;
            wallet = null;
        }

        public void UserRegistration()
        {
            WriteLine("Введите Ваше имя: ");
            LastName = ReadLine();
            WriteLine("Введите Вашу фамилию: ");
            FirstName = ReadLine();
            WriteLine("Введите Ваш логин: ");
            Login = ReadLine();
            WriteLine("Введите пароль: ");
            Password = ReadLine();
            Write("Введите номер телефона:+7 ");
            PhoneNumber = ReadLine();

            _verifyCode = RandomNumber(RANDOM_MIN, RANDOM_MAX);
            SmsSend(_accountSid, _accountToken, PhoneNumber, _verifyCode);

            WriteLine("Сейчас на ваш номер придет СМС с кодом. Введите его ниже: ");
            string text = ReadLine();

            bool isParsed = int.TryParse(text, out userCode);
            if (!isVerifyed(_verifyCode, userCode))
            {
                WriteLine("Не правильный код!");
            }
            else
                WriteLine("Верификация прошла успешно");
        }

        public bool LogIn(List<User> userL, User user)
        {
            string login;
            string password;
            WriteLine("Введите логин: ");
            login = ReadLine();
            WriteLine("Введите пароль: ");
            password = ReadLine();
            foreach(User item in userL)
            {
                if (userL.Contains(user))
                {
                    if (user.Login == login && user.Password == password)
                    {
                        return true;
                    }
                }
            }

            return false;
            
        }

        public void SmsSend(string accountSid, string accountToken, string ToPhoneNumber, int verifyCode)
        {
            accountSid = _accountSid;
            accountToken = _accountToken;

            TwilioClient.Init(accountSid, accountToken);

            var message = MessageResource.Create(
                body: verifyCode.ToString(),
                from: new PhoneNumber("+13163303949"),
                to: new PhoneNumber("+7" + ToPhoneNumber)
                );
        }

        public int RandomNumber(int minNum, int maxNum)
        {
            return random.Next(minNum, maxNum);
        }

        public bool isVerifyed(int recievedNum, int userNum)
        {
            if (recievedNum != userNum)
                return false;
            else return true;
        }

    }
}
