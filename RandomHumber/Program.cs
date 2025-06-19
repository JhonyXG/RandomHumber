

using System.Security.Cryptography.X509Certificates;



do
{

 
    Console.WriteLine(@"
▒█▀▀█ █▀▀█ █▀▀▄ █▀▀▄ █▀▀█ █▀▄▀█ 　 ▒█░▒█ █░░█ █▀▄▀█ █▀▀▄ █▀▀ █▀▀█ 
▒█▄▄▀ █▄▄█ █░░█ █░░█ █░░█ █░▀░█ 　 ▒█▀▀█ █░░█ █░▀░█ █▀▀▄ █▀▀ █▄▄▀ 
▒█░▒█ ▀░░▀ ▀░░▀ ▀▀▀░ ▀▀▀▀ ▀░░░▀ 　 ▒█░▒█ ░▀▀▀ ▀░░░▀ ▀▀▀░ ▀▀▀ ▀░▀▀");
    Console.WriteLine("\n Bem vindo ao RandomHumber");
    Console.WriteLine(" Advinhe o número escolhido por mim ");
    Console.WriteLine(" \n Digite um número entre 1 e 100");
    int numberChosen = int.Parse(Console.ReadLine());

    if (numberChosen < 55)
    {
        Console.WriteLine("chute mais alto");

    }
    if (numberChosen > 55)
    {
        Console.WriteLine("chute mais baixo");
    }
    if (numberChosen == 55)
    {
        Console.WriteLine("Parabens amigão você adivinhou!");
    }
    if (numberChosen > 100)
    {
        Console.WriteLine("amigo??????");
    }
    else
    {
        Console.WriteLine("Isso não né?");
    }
    switch (numberChosen)

    {
        case 0:
            Console.WriteLine("Você digitou zero, não é um número válido!");

            break;



    }

} while (true);





