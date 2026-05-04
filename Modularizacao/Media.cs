class Media{
    public static void Rodar(){
        double nota;
    
        Console.WriteLine("Digite sua nota:");
        nota = double.Parse(Console.ReadLine());

        char conceito = Calcular(nota);
        Console.WriteLine($"Seu conseito é {conceito}");
    }

    public static char Calcular(double nota){
        if(nota <= 4.9){
            return 'D';
        }
        else if(nota <= 6.9){
            return 'C';
        }
        else if(nota <= 8.9){
            return 'B';
        }
        else{
            return 'A';
        }
    }
}

