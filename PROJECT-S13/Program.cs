using System.Text.RegularExpressions;
using PROJECT_S13;
Console.OutputEncoding = System.Text.Encoding.UTF8;

Contribuente contribuente = new();

void RaccoltaDati()
{
    Console.WriteLine("========================================");
    Console.WriteLine("Benvenuto nel programma di calcolo dell'imposta");
    Console.WriteLine("========================================");
    bool controlloDati = false;

    do
    {
        controlloDati = false;
        Console.WriteLine();
        Console.WriteLine("Inserisci Nome");
        string? response = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("========================================");
        Console.WriteLine();
        if (!string.IsNullOrWhiteSpace(response) && response.All(x => char.IsLetter(x)))
        {
            controlloDati = true;
            contribuente.Nome = response;
        }
        else
        {
            Console.WriteLine("Inserire un nome valido!");
            Console.WriteLine();
            Console.WriteLine("========================================");
        }
    }
    while (!controlloDati);
    do
    {
        controlloDati = false;
        Console.WriteLine();
        Console.WriteLine("Inserire Cognome");
        string? response = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("========================================");
        Console.WriteLine();
        if (!string.IsNullOrWhiteSpace(response) && response.All(x => char.IsLetter(x)))
        {
            controlloDati = true;
            contribuente.Cognome = response;
        }
        else
        {
            Console.WriteLine("Inserire un cognome valido!");
            Console.WriteLine();
            Console.WriteLine("========================================");
        }
    }
    while (!controlloDati);
    do
    {
        controlloDati = false;
        Console.WriteLine();
        Console.WriteLine("Inserire Data di Nascita in formato GG/MM/AAAA");
        string? response = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("========================================");
        Console.WriteLine();
        if (!string.IsNullOrWhiteSpace(response) && DateTime.TryParse(response, out DateTime responseDate) && responseDate < DateTime.Today)
        {
            controlloDati = true;
            contribuente.DataNascita = responseDate;
        }
        else
        {
            Console.WriteLine("Inserire una Data di Nascita valida!");
            Console.WriteLine();
            Console.WriteLine("========================================");
        }
    }
    while (!controlloDati);
    do
    {
        controlloDati = false;
        Console.WriteLine();
        Console.WriteLine("Inserire il proprio Sesso nel formato M o F");
        string? response = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("========================================");
        Console.WriteLine();
        if (response.ToUpper() == "M" || response.ToUpper() == "F")
        {
            controlloDati = true;
            contribuente.Sesso = response;
        }
        else
        {
            Console.WriteLine("Inserire M o F per indicare il proprio Sesso");
            Console.WriteLine();
            Console.WriteLine("========================================");
        }
    }
    while (!controlloDati);
    do
    {
        controlloDati = false;
        Console.WriteLine();
        Console.WriteLine("Inserire Comune di Residenza");
        string? response = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("========================================");
        Console.WriteLine();
        if (!string.IsNullOrWhiteSpace(response) && response.All(x => char.IsLetter(x) || char.IsWhiteSpace(x)))
        {
            controlloDati = true;
            contribuente.ComuneResidenza = response;
        }
        else
        {
            Console.WriteLine("Inserire Comune di Residenza valido");
            Console.WriteLine();
            Console.WriteLine("========================================");
        }
    }
    while (!controlloDati);
    do
    {
        controlloDati = false;
        Console.WriteLine();
        Console.WriteLine("Inserire Codice Fiscale");
        string? response = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("========================================");
        Console.WriteLine();
        if(!string.IsNullOrWhiteSpace(response) && contribuente.CFValidate(response))        
        {
            controlloDati = true;
            contribuente.CodiceFiscale = response.ToUpper();
        }
        else
        {
            Console.WriteLine("Inserire Codice Fiscale valido");
            Console.WriteLine();
            Console.WriteLine("========================================");
        }
    }
    while (!controlloDati);
    do
    {
        controlloDati = false;
        Console.WriteLine();
        Console.WriteLine("Inserire Reddito Annuo");
        string? response = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("========================================");
        Console.WriteLine();
        if (!string.IsNullOrWhiteSpace(response) && double.TryParse(response, out double responseReddito) && responseReddito >= 0)
        {
            controlloDati = true;
            contribuente.RedditoAnnuale = responseReddito;
        }
        else
        {
            Console.WriteLine("Inserire Reddito Annuo valido");
            Console.WriteLine();
            Console.WriteLine("========================================");
        }
    }
    while (!controlloDati);
    contribuente.TaxShow();
}

RaccoltaDati();
