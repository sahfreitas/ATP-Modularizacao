class Exemplo{
    public static void  Rodar(){
        int x,y,z;

        Console.WriteLine("Digite o lado X:");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o lado Y:");
        y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o lado Z:");
        z = Convert.ToInt32(Console.ReadLine());

        if((x < y + z) && (y < x + z) && (z < x + y)){
            if(x == y && y == z){
                Console.WriteLine("Triângulo Equilátero");
            }
            else if (x == y || x == z || y == z){
                Console.WriteLine("Triângulo Isósceles");
            }
            else{
                Console.WriteLine("Triângulo Escaleno (ou Triângulo Qualquer)");
            }
        } else {
            Console.WriteLine("Os valores não formam um triângulo");
        }
    }
}