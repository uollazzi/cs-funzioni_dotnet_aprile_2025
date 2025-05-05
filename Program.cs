// lambda
// serve per creare funzioni anonime (usa e getta)
// action (non ritorna un valore)
// func (ritorna un valore)

List<int> numeri = [1, 2, 3, 4];

numeri.ForEach(x =>
{
    Console.WriteLine(x * x);
});

// 
var quadrati = numeri.Select(x => x * x); // [1,4,9,16]
Console.WriteLine(string.Join(",", quadrati));

// funzioni ricorsive
// funzione che richiama se stessa

// primi 5 numeri => 5+4+3+2+1 = 15
int SommaPrimiNNumeri(int n)
{
    if (n == 0)
        return 0;
    else
        return n + SommaPrimiNNumeri(n - 1);
}

int r = SommaPrimiNNumeri(3);
Console.WriteLine(r);