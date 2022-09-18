using Crackeador;
Cracker cracker = new Cracker();
cracker.Medium = 5;
cracker.High = 16;
cracker.SuperHigh = 25;
string[] bibliotecaUsuario = new string[1];
int time = 3;
bool cracking = true;
while (cracking)
{
    Console.WriteLine("Olá seja bem vindo!\nDigite seu login: ");
    cracker.Login = Console.ReadLine();
    Console.WriteLine($"Olá {cracker.Login} digite o nome do filme que quer baixar:");
    bibliotecaUsuario[0] = Console.ReadLine();
    Console.WriteLine("Qual a qualidade deseja baixar o seu filme?\n");
    Console.WriteLine("1 - 720p");
    Console.WriteLine("2 - 1080p");
    Console.WriteLine("3 - 4080p");
    string qualityMovie = Console.ReadLine();
    if (qualityMovie == "1")
    {
        Console.WriteLine("A qualidade do seu filme será em 720p");
        cracker.Download(cracker.Medium, time, bibliotecaUsuario[0]);
    }
    else if (qualityMovie == "2")
    {
        Console.WriteLine("A qualidade do seu filme será em 1080p");
        cracker.Download(cracker.High, time, bibliotecaUsuario[0]);
    }
    else if (qualityMovie == "3")
    {
        Console.WriteLine("A qualidade do seu filme será em 4080p");
        cracker.Download(cracker.SuperHigh, time, bibliotecaUsuario[0]);
    }
    else
    {
        Console.WriteLine("opção invalida");
    }
    Console.WriteLine("Digite 1 para encerrar ou 2 para continuar");
    string usuarioEscolhaEncerrar = Console.ReadLine();
    if (usuarioEscolhaEncerrar == "1")
    {
        Console.WriteLine("Encerrando...");
        cracking = false;
    }
    else
    {
    }
}