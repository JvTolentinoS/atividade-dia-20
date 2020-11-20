using System;

namespace atividade_dia_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Banco de dados - Desempenho escolar");
            
            string[] aluno = new string[10];
            float[] nota1 =new float[10];
            float[] nota2 =new float[10];
            float[] nota3 =new float[10];
            float[] nota4 =new float[10]; 
            float[] media =new float[10];
            
            for (var contador = 0; contador < 10; contador++)
            {
                Console.WriteLine("Digite o nome");
                aluno[contador] = Console.ReadLine();
                Console.WriteLine("Digite as notas");
                nota1[contador] = float.Parse(Console.ReadLine());
                nota2[contador] = float.Parse(Console.ReadLine());
                nota3[contador] = float.Parse(Console.ReadLine());
                nota4[contador] = float.Parse(Console.ReadLine());
                media[contador] = (nota1[contador] + nota2[contador] + nota3[contador] + nota4[contador])/4;  
            }
            Console.WriteLine("-------------------------------------------------------");
            for (var contador = 0; contador < 10; contador++){
                Console.Write("Nome: "+aluno[contador]+",");
                Console.WriteLine("  Média: "+media[contador]);
                if(media[contador] < 7){
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Reprovado");
                    Console.ResetColor();
                }else if( media[contador] >= 7){
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Aprovado");
                    Console.ResetColor();
                }
            }
            
        }
    }
}
