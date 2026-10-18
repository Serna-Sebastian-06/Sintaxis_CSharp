int width = 7;
int height = 5;
        
int area = width * height;
int perimeter = 2 * width + 2 * height;

width += 3;
height -= 2;

area = width * height;
perimeter = 2 * width + 2 * height;

Console.WriteLine("Valores Finales del Rectángulo");
Console.WriteLine("----------------------------------");
Console.WriteLine($"Ancho (width): {width}");
Console.WriteLine($"Alto (height): {height}");
Console.WriteLine($"Área (area): {area}");
Console.WriteLine($"Perímetro (perimeter): {perimeter}");