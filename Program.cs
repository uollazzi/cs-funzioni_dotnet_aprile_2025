using System.Globalization;
using System.Runtime.InteropServices;

void LogTitolo(string titolo)
{
    Console.WriteLine("");
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine(titolo + ":");
    Console.ResetColor();
}

// datetime e timespan
DateTime oggi = DateTime.Now;
LogTitolo("Data di oggi");
Console.WriteLine(oggi);

TimeSpan ora = oggi.TimeOfDay; // TimeSpan => intervallo di tempo
LogTitolo("Orario");
Console.WriteLine(ora);

// creare una nuova data
var scopertAmerica = new DateTime(1492, 10, 12);
var durata = new TimeSpan(23, 16, 0);
var durata2 = TimeSpan.FromMinutes(123);

scopertAmerica = scopertAmerica.Add(durata);
LogTitolo("Date e ora scoperta America");
Console.WriteLine(scopertAmerica);

var oggiUTC = DateTimeOffset.UtcNow; // data di adesso con fuso orario 0 GMT 0
LogTitolo("Data Offset UTC");
Console.WriteLine(oggiUTC);
Console.WriteLine(oggiUTC.LocalDateTime);

var oggiItalia = DateTimeOffset.Now;
Console.WriteLine(oggiItalia.DateTime);
Console.WriteLine(oggiItalia.UtcDateTime);

// epoch
LogTitolo("Epoch (Unix Time Stamp) => Numero di secondi/millisecondi passati dal 1/1/1970 00:00:00 UTC");
var epoch = DateTimeOffset.FromUnixTimeSeconds(190940400);
Console.WriteLine(epoch.LocalDateTime);
Console.WriteLine(oggiUTC.ToUnixTimeSeconds());

// formattazione
LogTitolo("Formattazione date");
Console.WriteLine(oggi.ToString());
Console.WriteLine(oggi.ToShortDateString());
Console.WriteLine(oggi.ToLongDateString());
Console.WriteLine(oggi.ToShortTimeString());
Console.WriteLine(oggi.ToString("dddd, dd MMM yyyy HH:mm"));
// https://freeasphosting.net/date-time-format-in-c-sharp-datetime-formatting-c-sharp.html
Console.WriteLine(oggi.ToString("dddd, dd MMMM yyyy HH:mm", new CultureInfo("en-EN")));
Console.WriteLine(oggi.ToString("dddd, dd MMMM yyyy HH:mm", new CultureInfo("it-IT")));

DateTime d;
bool isSuccess = DateTime.TryParse("10-22-2015", out d);
LogTitolo("TryParse Inglese (server in Italiano)");
Console.WriteLine(isSuccess);
Console.WriteLine(d);
Console.WriteLine();

isSuccess = DateTime.TryParse("22/10/2015", out d);
LogTitolo("TryParse Italiano (server in Italiano)");
Console.WriteLine(isSuccess);
Console.WriteLine(d);
Console.WriteLine();

CultureInfo provider = CultureInfo.InvariantCulture;
isSuccess = DateTime.TryParseExact("10-25-2019", "MM-dd-yyyy", provider, DateTimeStyles.None, out d);
Console.WriteLine(isSuccess);
Console.WriteLine(d);

// componenti delle date
LogTitolo("Componenti dell'oggetto DateTime");
Console.WriteLine(oggi.Date);
Console.WriteLine(oggi.Month);
Console.WriteLine(oggi.Hour);

// operazioni tra le date
var dataPleasePleaseMe = new DateTime(1963, 3, 22);
var dataLetItBe = new DateTime(1970, 5, 8);

LogTitolo("Operazioni sulle date");
Console.WriteLine(dataPleasePleaseMe);
Console.WriteLine(dataPleasePleaseMe.Add(new TimeSpan(48, 0, 0)));
Console.WriteLine(dataPleasePleaseMe.AddDays(-5));

var tempoPassato = dataLetItBe - dataPleasePleaseMe;
tempoPassato = dataLetItBe.Subtract(dataPleasePleaseMe); // alternativa
Console.WriteLine(Convert.ToInt32(tempoPassato.TotalDays / 365));
Console.WriteLine(dataPleasePleaseMe > dataLetItBe);