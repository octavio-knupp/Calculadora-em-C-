class Program
{
    static void Main()
    {
        //Soma os valores 
        double SomarDoisValores(double Valor1, double Valor2)
        {
            double Soma = Valor1 + Valor2;
            return Soma;
        }
        // Subtrai os valores
        double SubtrairDoisValores(double Valor1, double Valor2)
        {
            double Sub = Valor1 - Valor2;
            return Sub;
        }
        //Multiplica os valores
        double MultiplicarDoisValores(double Valor1, double Valor2)
        {
            double Mult = Valor1 * Valor2;
            return Mult;
        }
        //Divide os valores
        double DividirDoisValores(double Valor1, double Valor2)
        {
            double Div = Valor1 / Valor2;
            return Div;
        }
        double Potencia(double Valor1, double Valor2)
        {
            double Pot = Math.Pow(Valor1, Valor2);
            return Pot;
        }
        // Solicita o valor do usuário
        double SolicitarValorInteiro()
        {
            Console.WriteLine("Digite:");
            string texto = Console.ReadLine();
            double.TryParse(texto, out double valor);
            return valor;
        }
        // Solicita o operador do usuário
        string SolicitarOperador()
        {
            while (true) // fica repetindo até receber um operador válido
            {
                Console.WriteLine("Escolha a operação que deseja realizar (+ - * / ^) :");
                string operador = Console.ReadLine()?.Trim() ?? "";

                if (operador == "+" || operador == "-" || operador == "*" || operador == "/" || operador == "^")
                {
                    return operador; // sai do laço e retorna se for válido
                }

                Console.WriteLine("Operador inválido! Digite +, -, *, ^ ou /.");
            }
        }
        // Realiza o cálculo
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
                case "^": resultado= Potencia(Valor1, Valor2);
                    break;
                default:
                    Console.WriteLine("Operação inválida");
                    break;

            }
            Console.WriteLine($"Resultado: {resultado}");
        }
        Calcular();
        Console.ReadKey();
    }
}