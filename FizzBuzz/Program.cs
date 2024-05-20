namespace FizzBuzzinator1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("FizzBuzzinator");
            int t = Convert.ToInt32(Console.ReadLine());
            
            string[] fizzability = new string[t + 1];

            for (int i = 0; i <= t; i++)
            {
                string fizzpilation = "";

                if (i % 3 == 0)
                {
                    fizzpilation += "Fizz";
                }
                if (i % 5 == 0)
                {
                    fizzpilation += "Buzz";
                }
                if (fizzpilation.Length == 0)
                {
                    fizzpilation += Convert.ToString(i);
                }
                fizzability[i] = fizzpilation;
            }
            Console.Write(string.Join("\n",fizzability));
        }
        
    }

}
