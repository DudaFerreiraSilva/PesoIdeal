double altura, pesoIdeal;
string sexo;

Console.ForegroundColor = ConsoleColor.Cyan;
Console.Write("Digite sua altura em m : ");
altura = Convert.ToDouble(Console.ReadLine());
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Cyan;
Console.Write("Sexo [M]asculino / [F]eminino  : ");
sexo = Console.ReadLine()!.ToUpper().Trim();
Console.ResetColor();

if (sexo != "M" && sexo != "F")
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("Não possuo fórmula para cálculo.");
    Console.ResetColor();
}
else
{
    if (sexo == "M")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        pesoIdeal = altura * 72.7 - 58.0;
        Console.ResetColor();
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Green;
        pesoIdeal = altura * 62.1 - 44.7;
        Console.ResetColor();
    }
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Seu peso ideal é {pesoIdeal:N1}kg.");
    Console.ResetColor();
}
