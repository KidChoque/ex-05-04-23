Console.WriteLine($"Digite seu usuário:");
string user = Console.ReadLine();


Console.WriteLine($"Digite sua senha:");
string senha = Console.ReadLine();


while ( user == senha  )
{
    Console.WriteLine($"A senha não pode ser igual ao usuário.Digite novamente:");

    senha = Console.ReadLine();
    
    
}

Console.WriteLine($"Login válido");
