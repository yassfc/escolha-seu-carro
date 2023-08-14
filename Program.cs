using System;

public class Program {
    public static void Main() {

       //Qual carro terá
       // 0 = Ferrari
       // 1 - Camaro
       // 2 - Bugatti
       // 3 - Celta
       // 4 - Tesla
       // 5 - Fusca
       
       Inicio:
       Console.Clear();
        int pergunta;
        string carro = ""; 
        string pergunta2= "";

        Console.WriteLine("Escolha de 1 a 5, será seu carro");
        pergunta = int.Parse(Console.ReadLine());

        switch (pergunta) {
            case 1: 
                carro = "Ferrari";
                break;

            case 2:
                carro = "Camaro";
                break;

            case 3:
                carro = "Bugatti"; 
                break;

            case 4:
                carro = "Tesla";
                break;

            case 5:
                carro = "Fusca";
                break;
            
            default: 
                Console.WriteLine("Opção inválida");
                return; 
        }

        Console.WriteLine("Seu carro será {0}", carro); 
        Console.WriteLine(" "); 
        Console.WriteLine("Deseja recomeçar? Sim/Não"); 
        pergunta2 = Console.ReadLine();

        if(pergunta2 == "Sim"){
         goto Inicio;

      }else{
     Console.ReadLine();

      }
        }


        }

      
    

