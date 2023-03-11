namespace Methods;
class Program
{
    static void Main(string[] args)
    {
        int a = 5;
        int b = 7;
        Console.WriteLine(a+b);                // 12


        Sample sample = new Sample();
        int result = Sum(a,b); 
        sample.Write(result.ToString());      // 12


        int result2 = sample.IncreaseAndSum(ref a, ref b);
        sample.Write(result2.ToString());     // 14

        Console.WriteLine(a+b);               // 14    
    }

    static int Sum(int number1, int number2)
    {
        return number1 + number2;
    }

    
}
    class Sample
    {
        public void Write(string text)
        {
            Console.WriteLine(text);
        }

        public int IncreaseAndSum(ref int num1, ref int num2)
        {
            num1 += 1;
            num2 += 1;
            return num1 + num2;

        }
    }

