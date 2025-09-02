Console.WriteLine("Olá! Escreva um valor");
decimal valor = decimal.Parse(Console.ReadLine()!);
decimal antecessor = valor - 1;
Console.WriteLine($"O antecessor do {valor} é = {antecessor}");
