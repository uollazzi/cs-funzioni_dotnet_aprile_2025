void LogTitolo(string titolo)
{
    Console.WriteLine("");
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine(titolo + ":");
    Console.ResetColor();
}

// eccezioni
LogTitolo("Eccezioni comuni di sistema");

var n = 2;
var m = 0;

// Console.WriteLine("Divisione per zero");
// var r = n / m;

// string[] animali = ["cane", "gatto"];
// Console.WriteLine("Indice oltre il range");
// Console.WriteLine(animali[5]);

// try / catch
// serve per gestire le eccezioni in modo che il ns programma non crashi
LogTitolo("Costrutto try/catch");

try
{
    var r = n / m;
}
catch (Exception ex)
{
    // blocco eseguito solo se c'è un errore
    Console.WriteLine(ex.Message);
}
finally
{
    // blocco eseguito comunque anche se c'è stato un errore
    Console.WriteLine("Eseguito in tutti i casi");
}

LogTitolo("try / catch multipli");

try
{
    var t = File.ReadAllText("pippo.txt");

    var numero = int.Parse(t);

    var r2 = n / numero;
}
catch (FileNotFoundException ex)
{
    Console.WriteLine(ex);
}
catch (FormatException ex)
{
    Console.WriteLine("il testo non è un numero");
}
catch (Exception ex)
{
    Console.WriteLine("Eccezione generica.");
}

// throw e eccezioni custom
var anni = 20;

if (anni > 18)
{
    Console.WriteLine($"Ha la patente da {anni - 18} anni");
}
else
{
    throw new Exception("Non ha la patente");
}

void CalcolaAnniPatente(int? anni)
{
    if (!anni.HasValue)
    {
        throw new NullReferenceException("Specificare gli anni");
    }

    if (anni < 18)
        throw new Exception("Non ha la patente!");

    Console.WriteLine($"Ha la patente da {anni - 18} anni");
}

int? eta = 9;

try
{
    CalcolaAnniPatente(eta);
}
catch (NullReferenceException ex)
{
    Console.WriteLine("Eccezione null gestita.");
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine("Eccezione generica gestita.");
    Console.WriteLine(ex.Message);
}

Console.WriteLine("Finito");
