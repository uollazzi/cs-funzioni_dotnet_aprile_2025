using System.ComponentModel;

void Saluta()
{
    Console.WriteLine($"Ciao, sono le {DateTime.Now}");
    // Thread.Sleep(1000);
}

Saluta();

for (int i = 0; i < 4; i++)
{
    Saluta();
}

Console.WriteLine("====================================");

// valori di ritorno
string RitornaUnSaluto()
{
    return $"Ciao, sono le {DateTime.Now}";
}

for (int i = 0; i < 3; i++)
{
    string saluto = RitornaUnSaluto();
    Console.WriteLine(saluto);
    // Thread.Sleep(1000);
}

int TiraUnDado()
{
    Random rnd = new Random();

    int numero = rnd.Next(1, 7);

    return numero;
}

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Numero random: {TiraUnDado()}");
}

// tupla
// la tupla fornisce una sintassi concisa per raggruppare dati
(int, int) tupla = (3, 7);
var tupla2 = (4, 9.5m, "ciao");
Console.WriteLine($"Valore {tupla2.Item2} di tipo {tupla2.Item2.GetType()}");

(int, int) TiraDueDadi()
{
    int n1 = TiraUnDado();
    int n2 = TiraUnDado();

    return (n1, n2);
}

var r = TiraDueDadi();
Console.WriteLine($"Risultato: {r}");
Console.WriteLine($"Numero 1: {r.Item1}");
Console.WriteLine($"Numero 2: {r.Item2}");

(int dado1, int dado2) TiraDueDadiConNome()
{
    int n1 = TiraUnDado();
    int n2 = TiraUnDado();

    return (dado1: n1, dado2: n2);
}

var rn = TiraDueDadiConNome();
Console.WriteLine($"Risultato: {rn}");
Console.WriteLine($"Numero 1: {rn.dado1}");
Console.WriteLine($"Numero 2: {rn.dado2}");