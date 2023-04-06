Console.WriteLine($" Digite sua nota ");

float nota = float.Parse(Console.ReadLine());


while( nota < 0 || nota > 10  )
{
    Console.WriteLine($" Nota inválida.Digite novamente: ");
    
    nota = float.Parse(Console.ReadLine());
    

    
}
