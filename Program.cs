using System.Net.WebSockets;

int AggiungiUno(int numero)
{
    return numero + 1;
}

int due = 2;
int tre = AggiungiUno(due);

Console.WriteLine($"Aggiungi 1: {tre}");

int Somma(int addendo1, int addendo2)
{
    return addendo1 + addendo2;
}

Console.WriteLine($"Somma: {Somma(7, 9)}");

int r = Somma(addendo2: 4, addendo1: 7);

// C# passa i parametri come valore di default
// cioè di default, passa una copia della variabile

void quadratoByVal(int valParameter)
{
    valParameter *= valParameter;
}

int numero = 4;
quadratoByVal(numero);
Console.WriteLine(numero);

// ref passa un riferimento ad una variabile
void quadratoByRef(ref int refParameter)
{
    refParameter *= refParameter;
}
quadratoByRef(ref numero);
Console.WriteLine(numero);

// out serve da segnaposto per un valore ritornato dalla funzione
string dieci = "dieci";
int risultato;
bool ok = int.TryParse(dieci, out risultato);

if (ok)
{
    Console.WriteLine($"{dieci} convertito con successo in {risultato}");
}
else
{
    Console.WriteLine($"Non sono riuscito a convertire {dieci} in numero");
}

// numero parametri variabile
int SommaTutto(params int[] numeri)
{
    int r = 0;
    foreach (var n in numeri)
    {
        r += n;
    }

    return r;
}

Console.WriteLine(SommaTutto(3, 56, 78, 34, 56, 7, 7));

int[] prezzi = [4, 67, 34, 56, 1];
Console.WriteLine(SommaTutto(prezzi));

// parametri di default (facoltativi)
void Saluta(string nome = "a tutti")
{
    Console.WriteLine($"Ciao {nome}");
}
Saluta("Gigi");
Saluta();

// i valori di default, ma anche params, vanno dichiarati come ultimi (posizione) parametri della funzione
void SalutaNVolte(string nome, string saluto = "Ciao", int volte = 3)
{
    for (int i = 0; i < volte; i++)
    {
        Console.WriteLine($"{saluto} {nome}");
    }
}

SalutaNVolte("Bruno");
SalutaNVolte("Mario", "Salve");
SalutaNVolte("Anna", "Salve", 8);

// Salutare 5 volte "Luisa" (usando Ciao come valore di default)
SalutaNVolte("Luisa", volte: 5);