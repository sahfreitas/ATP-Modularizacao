class Fibonacci{
    public static void Compilar(){
        int a = 0, b = 1, num, trava = 20;

        Console.WriteLine("Fibonacci:");

        for (int i = 0; i < trava; i++){
            Console.Write(a + " ");
            num = a + b;
            a = b;
            b = num;
        }
    }
}