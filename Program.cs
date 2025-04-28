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