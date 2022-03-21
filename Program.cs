string frasedigitada, frasememetomervoso;

Console.WriteLine("Usuario,digite por favor oque você acha desse programa:");
frasedigitada= Console.ReadLine()!;

frasememetomervoso = $"{frasedigitada.Remove(10)}... NÃO, PERA.\nTô nervoso";

Console.WriteLine(frasememetomervoso);