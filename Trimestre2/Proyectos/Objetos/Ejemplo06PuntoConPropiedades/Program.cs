// See https://aka.ms/new-console-template for more information

Punto p = new Punto();
Punto q = new Punto();
p.x = 11;
p.y = 8;
q.x = 14;
q.y = 11;
Console.WriteLine($"p = {p}");
Console.WriteLine($"q = {q}");
Console.WriteLine($"dist({p},{q}) = {p.distancia(q)}");

