bool lago;
string txt;
double kgPeixe,multa = 0;
Console.WriteLine("Avaliação de Legalidade de pesca");
Console.Write(@"Onde Pescou?
C - Águas continentais e estuarinas
M - Águas marinhas
");
txt = Console.ReadLine()!;
if(txt == "M"){lago = true;}
else if(txt == "C"){lago = false;}
else{ return;}
Console.Write("");