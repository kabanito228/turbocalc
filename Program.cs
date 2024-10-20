internal class Program
{
    private static void Main(string[] args)
    {
        //Приветствие
        Console.WriteLine("Добро пожаловать в турбокалькулятор!");
        //while
        bool sost = true;
        while (sost == true)
        {
            //первое число
            Console.WriteLine("Введите первое число.");
            //захват ошибок
            try
            {
                float a = float.Parse(Console.ReadLine());
                //второе число
                Console.WriteLine("Введите второе число");
                float b = float.Parse(Console.ReadLine());
                //действие
                Console.WriteLine("Введите действие.");
                string act = Console.ReadLine();
                //финал
                switch (act)
                {
                    case "+":
                        {
                            float c = a + b;
                            Console.WriteLine(c);
                        }
                        break;
                    case "-":
                        {
                            float c = a - b;
                            Console.WriteLine(c);
                        }
                        break;
                    case "*":
                        {
                            float c = a * b;
                            Console.WriteLine(c);
                        }
                        break;
                    case "/":
                        {
                            float c = a / b;
                            Console.WriteLine(c);
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("Непредвиденная ошибка");
                            sost = false;
                        }
                        break;
                }
            }
            //реакция на ошибки
            catch (Exception)
            {
                Console.WriteLine("Непредвиденная ошибка");
                sost = false;
            }
        }
        Console.ReadKey();
    }
}