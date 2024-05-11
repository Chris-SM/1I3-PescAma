bool lago;
string txt;
double kgPeixe;

Console.WriteLine("Avaliação de Legalidade de pesca");
Console.Write(@"Onde Pescou?
C - Águas continentais e estuarinas
M - Águas marinhas
");

txt = Console.ReadLine()!.ToUpper().Substring(0);
if(txt == "M")
{
    lago = true;
}
else if(txt == "C")
{
    lago = false;
}
else
{
    return;
}

Console.Write("Quantos Kilos a Pesca alcançou? ");
kgPeixe = Convert.ToInt32(Console.ReadLine());
if(kgPeixe<=10)
{
    Console.Write("Bem, com todos os dados informados não terá uma multa para você");
}
else if(kgPeixe>10 && !lago)
{
    Console.WriteLine($"Você deve {(kgPeixe-10)*20+1000:C}");
}
else
{
    Console.WriteLine($"Você deve {(kgPeixe-15)*20+1000:C}");
}