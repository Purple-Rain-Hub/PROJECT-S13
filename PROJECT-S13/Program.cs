using PROJECT_S13;

Contribuente contribuente = new();

void RaccoltaDati()
{
    Console.WriteLine("========================================");
    Console.WriteLine("Benvenuto nel programma di calcolo dell'imposta");
    Console.WriteLine("========================================");
    Console.WriteLine();
    bool controlloDati = false;
    do
    {
        controlloDati = false;
        Console.WriteLine("Inserisci Nome");
        string? response = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("========================================");
        Console.WriteLine();
        if (!string.IsNullOrWhiteSpace(response) && response.Any(x => char.IsLetter(x)))
        {
            controlloDati = true;
            contribuente.Nome = response;
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Inserire un nome valido!");
            Console.WriteLine();

        }
    }
    while (!controlloDati);
    do
    {
        controlloDati = false;
        Console.WriteLine("Inserire Cognome");
        string? response = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("========================================");
        Console.WriteLine();
        if (!string.IsNullOrWhiteSpace(response) && response.Any(x => char.IsLetter(x)))
        {
            controlloDati = true;
            contribuente.Cognome = response;
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Inserire un cognome valido!");
            Console.WriteLine();
        }
    }
    while (!controlloDati);
    do
    {
        controlloDati = false;
        Console.WriteLine("Inserire Data di Nascita in formato GG/MM/AAAA");
        string? response = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("========================================");
        Console.WriteLine();
        if (!string.IsNullOrWhiteSpace(response) && DateTime.TryParse(response, out DateTime responseDate))
        {
            controlloDati = true;
            contribuente.DataNascita = responseDate;
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Inserire una Data di Nascita valida!");
            Console.WriteLine();
        }
    }
    while (!controlloDati);
    do
    {
        controlloDati = false;
        Console.WriteLine("Inserire il proprio Sesso nel formato M o F");
        string? response = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("========================================");
        Console.WriteLine();
        if (response.ToLower() == "m" || response.ToLower()== "f")
        {
            controlloDati = true;
            contribuente.Sesso = response;
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Inserire M o F per indicare il proprio Sesso");
            Console.WriteLine();
        }
    }
    while (!controlloDati);
    do
    {
        controlloDati = false;
        Console.WriteLine("Inserire Comune di Residenza");
        string? response = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("========================================");
        Console.WriteLine();
        if (!string.IsNullOrWhiteSpace(response) && response.Any(x => char.IsLetter(x)))
        {
            controlloDati = true;
            contribuente.Sesso = response;
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Inserire Comune di Residenza valido");
            Console.WriteLine();
        }
    }
    while (!controlloDati);
    do
    {
        controlloDati = false;
        Console.WriteLine("Inserire Codice Fiscale");
        string? response = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("========================================");
        Console.WriteLine();
        char[] responseArray = response.ToUpper().ToCharArray();
        if(!string.IsNullOrWhiteSpace(response) && response.Length == 16 && contribuente.Cognome.ToUpper().Contains(responseArray[0]) && contribuente.Cognome.ToUpper().Contains(responseArray[1]) && contribuente.Cognome.ToUpper().Contains(responseArray[2]) && contribuente.Nome.ToUpper().Contains(responseArray[3]) && contribuente.Nome.ToUpper().Contains(responseArray[4]) && contribuente.Nome.ToUpper().Contains(responseArray[5]))
        {   
            controlloDati = true;
            contribuente.CodiceFiscale = response;
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Inserire Codice Fiscale valido");
            Console.WriteLine();
        }
    }
    while (!controlloDati);
    do
    {
        controlloDati = false;
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
            Console.WriteLine();
            Console.WriteLine("Inserire Reddito Annuo valido");
            Console.WriteLine();
        }
    }
    while (!controlloDati);

}

RaccoltaDati();
