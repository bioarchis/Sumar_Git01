namespace Sumar_Git01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables
            double num1, num2, resultado;
            int option;

            do {
               
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Salir");
                Console.WriteLine("Elige una opcion:");
                option = int.Parse(Console.ReadLine());
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
                    case 4:
                        Console.WriteLine("Saliendo....");
                        break;
                    default:
                        Console.WriteLine("Valores no validos");
                        break;
                }
       
            } while (option != 1 && option !=   2 && option != 3 && option != 5);
        }
        //metodos

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
