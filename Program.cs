using System.Security.Cryptography;

Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("Rolagem de Dado");
Console.ResetColor();
Console.WriteLine();

Console.Write("Quantas faces? ");
int faces = Convert.ToInt32(Console.ReadLine());
int sorteou = RandomNumberGenerator.GetInt32(1, faces + 1);

Console.WriteLine($"\nSorteou: {sorteou}");

