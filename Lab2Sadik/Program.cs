Console.Write("Введите R1: ");
double R1 = double.Parse(Console.ReadLine());

Console.Write("Введите R2: ");
double R2 = double.Parse(Console.ReadLine());

Console.Write("Введите R3: ");
double R3 = double.Parse(Console.ReadLine());

double v1 = (4 / 3) * Math.PI * Math.Pow(R1, 3);
double v2 = (4 / 3) * Math.PI * Math.Pow(R2, 3);
double v3 = (4 / 3) * Math.PI * Math.Pow(R3, 3);

double Z = (v1 + v2 + v3) / 3;

Console.WriteLine($"Z = {Z:F2}");