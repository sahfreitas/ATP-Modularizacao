class Valores{
    public static void Rodar(){
        double nota;
        int num = 1;
        

        while(num != 0){
            Console.Write("Digite um valor: ");
            int valor = int.Parse(Console.ReadLine());

            if(Verificador(valor)){
            Console.WriteLine("Número é Positivo");
            }else{
            Console.WriteLine("Número é Negativo");
            }
        }
    }

    public static bool Verificador(int valor){
        if(valor < 0){
            return false;
        }
        else{
            return true;
        }
    }
}