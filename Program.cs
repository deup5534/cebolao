Console.WriteLine("Escreva algo que o nosso grande cebolinha diria!");

string palavra = Console.ReadLine()!;

string palavla = palavra

.Replace("r","l")
.Replace("R","L")
.Replace("r","L");

Console.WriteLine($"ele com certeza diria: {palavla}");