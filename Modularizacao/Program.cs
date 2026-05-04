
class Progam{
    public static void Main(){
        string entrada = "";
        
        while(entrada != "fim"){
            Media.Rodar();
            Valores.Rodar();
            Mdc.Rodar();
            
            entrada = Console.ReadLine();
        }
    }
 }