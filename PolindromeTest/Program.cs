namespace PalindromeTest
{
    

    internal class Program
    {
        static void Main(string[] args)
        {
            //Простой алгоритм для проверки строки на палиндром 
            

            Console.WriteLine("Введите текст");
            string? text = Console.ReadLine();


            if (text is null)
            {
                Console.WriteLine("Текст не может быть равен null");
                Main(args);
            }
            Console.WriteLine("Вы уверены что ваш текст = {0}  Y - Да, любое другое значение - повтор", text);
            if (Console.ReadLine()?.ToUpper() == "Y")
            {
                if (text is not null)
                {
                    if (Palindrome.Test(StringTransfer.Transfer(text)))
                    {
                        Console.WriteLine("Вы ввели палиндром! {0}", StringTransfer.Transfer(text));
                    }
                    else
                    {
                        Console.WriteLine("Ваше значение не палиндром {0}", StringTransfer.Transfer(text));
                    }
                }
                else
                {
                    Console.WriteLine("Текст не может быть равен null");
                }
            }
            else
            {
                Console.WriteLine("Попробуем еще раз");
                Main(args);
            }

            Console.WriteLine("Повторим? Y - Да, любое другое значение - выход");
            if (Console.ReadLine()?.ToUpper() == "Y")Main(args);
            


        }

    }
    public static class Palindrome
    {
        public static bool Test(string value)
        {
            char[] symb = new char[value.Length];
            symb = value.ToCharArray();

            for (int i = 0; i < value.Length; i++)
            {
                if (symb[i] != symb[value.Length - i - 1])
                {
                    return false;
                }
            }


            return true;

        }
    }
        public static class StringTransfer
        {
            public static string Transfer(string value)
            {
                string result = "";
                char[] notallowedchars = { ' ', '?', '!', '.', ',' };//Можно дополнить 

                bool SkipNotAllowedSym(char value)
                {
                    foreach (char a in notallowedchars)
                    {
                        if (value == a)
                        {
                            return false;

                        }

                    }
                    return true;
                }

                try
                {
                    foreach (char c in value)
                    {
                        if (SkipNotAllowedSym(c))
                        {
                            result += c;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                result = result.ToLower();
                return result;// Возвращает строку в нижнем регистре, без органичений из массива notallowedchars
            }
        }


    }
