class Progam{
    public static void Main(){
        string entrada = "";
        
        while(entrada != "fim"){
            Exemplo.Rodar();
            Fibonacci.Compilar();

            entrada = Console.ReadLine();
        }
    }
}
