Console.WriteLine("Calcule a hipotenusa!");
Console.WriteLine("Digite o lado A: ");
double a = Convert.ToDouble (Console.ReadLine());
Console.WriteLine("Digite o lado B: ");
double b = Convert.ToDouble(Console.ReadLine());

double c = Math.Sqrt (a * a + b * b);

Console.WriteLine("A hipotenusa é: " + c);

Console.ReadKey();