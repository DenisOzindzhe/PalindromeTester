namespace DelegatesEvents
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Delegates and Events testing
            // Learn more, try hard
            Check check;
            check = Checking;

            string text = "А роза упала на лапу Азора";
            Console.WriteLine(text);
            check(text);


        }
        static public void Ru()
        {
            Console.WriteLine("Русский язык выбран");
        }
        static public void Eng()
        {
            Console.WriteLine("English was choosen");
        }
        static public int Sum(int x, int y) 
            
        {
            return (x + y);
        }
        static public void Checking(string val)
        {
            string? result = "";
            try
            {
                foreach (char c in val)
                {
                    if (c != ' ')
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
            Console.WriteLine(result);

            char[] symb = new char[result.Length];
            symb = result.ToCharArray();
            bool isThis = true;
            for (int i = 0; i < result.Length; i++)
            {
                if (symb[i] != symb[result.Length - i - 1])
                {
                    Console.WriteLine("IS NOT!");
                    isThis = false;
                    break;
                }
            }
            if (isThis)
            {
                Console.WriteLine("It is!");
            }
            

        }

        delegate int Operation(int x, int y);
        delegate void Message();
        delegate void Check(string value);
    }
}