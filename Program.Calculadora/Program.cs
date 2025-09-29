class program
{
    static void Main()
    {
      
        double SomarDoisValores(double Valor1, double Valor2)
        {
            double Soma = Valor1 + Valor2;
            return Soma;
        }
        double SubtrairDoisValores(double Valor1, double Valor2)
        {
            double Sub = Valor1 - Valor2;
            return Sub;
        }
        double MultiplicarDoisValores(double Valor1, double Valor2)
        {
            double Mult = Valor1 * Valor2;
            return Mult;
        }
        double DividirDoisValores(double Valor1, double Valor2)
        {
            double Div = Valor1 / Valor2;
            return Div;
        }
        double SolicitarValorInteiro()
        {
            Console.WriteLine("Digite:");
            string texto = Console.ReadLine();
            double.TryParse(texto, out double valor);
            return valor;
        }
        string SolicitarOperador()
        {
            Console.WriteLine("Escolha a operação que deseja realizar (+-/*) :");
            string operador = Console.ReadLine();
            return operador ?? "";
        }

         void Calcular()
        {
            string operador = SolicitarOperador();
            double Valor1 = SolicitarValorInteiro();
            double Valor2 = SolicitarValorInteiro();
            double resultado = 0;
            switch (operador)
            {
                case "+":
                    resultado = SomarDoisValores(Valor1, Valor2);
                    break;
                case "-":
                    resultado = SubtrairDoisValores(Valor1, Valor2);
                    break;
                case "/":
                    resultado = DividirDoisValores(Valor1, Valor2);
                    break;
                case "*":
                    resultado = MultiplicarDoisValores(Valor1, Valor2);
                    break;
                default: Console.WriteLine("Operação inválida");
                    break;

            }
            Console.WriteLine($"Resultado: {resultado}");
        }
        Calcular();
        Console.ReadKey();
    }
    
}