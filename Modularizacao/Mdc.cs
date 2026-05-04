class Mdc{
    public static void Rodar() {
        Console.Write("Digite o primeiro número: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        int num2 = int.Parse(Console.ReadLine());

        int resultado = Calcular(num1, num2);

        Console.WriteLine($"MDC = {resultado}");
    }

    public static int Calcular(int num1, int num2) {
        while (num2 != 0) {
            int resto = num1 % num2;
            num1 = num2;
            num2 = resto;
        }
        return num1;
    }
}