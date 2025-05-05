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