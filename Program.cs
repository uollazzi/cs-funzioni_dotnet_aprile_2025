// filesystem => files e cartelle del computer
void LogTitolo(string titolo)
{
    Console.WriteLine("");
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine(titolo + ":");
    Console.ResetColor();
}

// leggere contenuto di una cartella

// cartella corrente
LogTitolo("root");
var root = Directory.GetCurrentDirectory();
Console.WriteLine(root);

// informazioni sulla directory
var rootInfo = new DirectoryInfo(root);
LogTitolo("rootInfo.Name");
Console.WriteLine(rootInfo.Name);
LogTitolo("rootInfo.Parent");
Console.WriteLine(rootInfo.Parent);

// trovare le sottodirectory
// var dirs = Directory.GetDirectories(root); // percorso di directory assoluto
// var dirs = Directory.GetDirectories("documenti"); // percorso di directory relativo
var dirs = Directory.GetDirectories("documenti", "prev*", SearchOption.AllDirectories); // percorso di directory relativo

// overloads
// modi diversi (elenco di parametri) di chiamare la setssa funzione

LogTitolo("Lista directories");
foreach (var dir in dirs)
{
    Console.WriteLine(dir);
}

LogTitolo("Lista directories info");
var dirsInfo = rootInfo.GetDirectories();
foreach (var di in dirsInfo)
{
    Console.WriteLine(di.Name);
}

// files
var annoFatture = 2021;
var fatturePath = Path.Combine("documenti", "fatture", annoFatture.ToString());
var files = Directory.GetFiles(fatturePath);
LogTitolo("Lista files");
Console.WriteLine(string.Join("\n", files));

var filesInfo = rootInfo.GetFiles("*.pdf", SearchOption.AllDirectories);
LogTitolo("Lista files FileInfo");
foreach (var fi in filesInfo)
{
    // alternativa 1
    Console.WriteLine($"{fi.CreationTime} {fi.Directory?.Name} {fi.Name}");

    // alternativa 2
    // var dir = fi.Directory == null ? "DIR NON TROVATA" : fi.Directory.Name;
    var dirName = fi.Directory?.Name;
    var dir = dirName ?? "DIR NON TROVATA";
    Console.WriteLine($"{fi.CreationTime} {dir} {fi.Name}");
}

LogTitolo("Lista files FileInfo Elegante");
Console.WriteLine(string.Join("\n", filesInfo.Select(fi => $"{fi.CreationTime} {fi.Directory?.Name} {fi.Name}")));

// leggere il contenuto 
var filePath = Path.Combine("documenti", "preventivi", "todo.txt");
LogTitolo("Lettura file di testo");
var testo = File.ReadAllText(filePath);
Console.WriteLine(testo);

var righe = File.ReadAllLines(filePath);
LogTitolo("Lettura testo riga per riga");

var numeroRiga = 1;
foreach (var riga in righe)
{
    Console.WriteLine($"{numeroRiga} - {riga}");
    numeroRiga++;
}

// scrittura file
// se il percorso non esiste, nel momento in cui scriviamo viene creato
filePath = @"C:\Progetti\Tutorials\LAB4T\dotNET\dotnet_aprile_2025\cs-funzioni\documenti\note.txt";
string[] righeDaScrivere = ["Nota 1", "Nota 2", "Nota 3"];
File.WriteAllLines(filePath, righeDaScrivere);

string[] righeDaRiScrivere = ["Nota 01", "Nota 02", "Nota 03"];
File.AppendAllLines(filePath, righeDaRiScrivere);

// StremWriter, StreamReader


// matteo 10:08
