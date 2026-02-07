namespace Sumar_Git01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables
            double num1, num2, resultado;
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("Elige una opcion:");
            int option = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriber el primer numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escribe el segundo número: ");
            num2 = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    resultado = Suma(num1, num2);
                    Console.WriteLine($"El resultado de la suma es: {resultado}");
                    break;
                 case 2:
                    resultado = Resta(num1, num2);
                    Console.WriteLine($"El resultado de la suma es: {resultado}");
                    break;
                case 3:
                     resultado = Multiplica(num1, num2);
                    Console.WriteLine($"El resultado de la suma es: {resultado}");
                    break;
                default: Console.WriteLine("Valores no validos");
                break; 
            }

        }

       static double Suma(double num1, double num2) 
        {
            double resultado= num1 + num2;   
            return resultado;
        }
       static double Resta(double num1, double num2) 
        {
            double resultado= num1 - num2;   
            return resultado;
        }
      static double Multiplica(double num1, double num2) 
        {
            double resultado= num1 * num2;   
            return resultado;
        }
    }
}
