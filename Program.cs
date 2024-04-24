namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("A >> ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("B >> ");
                int b = int.Parse(Console.ReadLine());

                Console.Write("Действие >> ");
                string c = Console.ReadLine();

                switch (c)
                {
                    case "*":
                        Console.WriteLine(new folded().Calculate(a, b));
                        break;
                    case "/":
                        Console.WriteLine(new Division().Calculate(a,b));
                        break;
                    case "-":
                        Console.WriteLine(a - b);
                        break;
                    case "+":
                        Console.WriteLine(a + b);
                        break;
                }
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
