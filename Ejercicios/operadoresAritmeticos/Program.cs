int a = 15;
int b = 5;

string texto = "Número a: " + a + " | Número b: "+ b;

int suma = a + b;       
int resta = a - b;       
int multiplicacion = a * b;  
int division = a / b;         

Console.WriteLine(texto);
Console.WriteLine("---------------------------");
Console.WriteLine($"Suma (a + b):{suma}");
Console.WriteLine($"Resta (a - b):{resta}");
Console.WriteLine($"Multiplicación (a * b):{multiplicacion}");
Console.WriteLine($"División (a / b):{division}");