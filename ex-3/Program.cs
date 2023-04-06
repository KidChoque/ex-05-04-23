Console.WriteLine($"Digite um número:");
int tabuada = int.Parse(Console.ReadLine());

//primeira atribuição antes do comando;quantidade de vezes ou condição do comando;comando a ser repetido toda vez após a leitura do código
for (int multiplicador = 1; multiplicador <= 10; multiplicador++)
{
    Console.WriteLine($"{tabuada} * {multiplicador} =  {tabuada * multiplicador}");

}


