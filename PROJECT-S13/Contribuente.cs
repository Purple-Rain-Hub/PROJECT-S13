﻿
using System.Text.RegularExpressions;

namespace PROJECT_S13
{
    internal class Contribuente
    {
        public string? Nome { get; set; }
        public string? Cognome { get; set; }
        public DateTime DataNascita { get; set; }
        public string? Sesso { get; set; }
        public string? ComuneResidenza { get; set; }
        public string? CodiceFiscale { get; set; }
        public double RedditoAnnuale { get; set; }
        public double Imposte { get; set; }

        public bool CFValidate(string response)
        {
            char[] responseArray = response.ToUpper().ToCharArray();
            string controlloAnno = DataNascita.ToString("yy");
            string controlloMese;
            string controlloGiorno;
            switch (DataNascita.Month)
            {
                case 01:
                    controlloMese = "A";
                    break;
                case 02:
                    controlloMese = "B";
                    break;
                case 03:
                    controlloMese = "C";
                    break;
                case 04:
                    controlloMese = "D";
                    break;
                case 05:
                    controlloMese = "E";
                    break;
                case 06:
                    controlloMese = "H";
                    break;
                case 07:
                    controlloMese = "L";
                    break;
                case 08:
                    controlloMese = "M";
                    break;
                case 09:
                    controlloMese = "P";
                    break;
                case 10:
                    controlloMese = "R";
                    break;
                case 11:
                    controlloMese = "S";
                    break;
                case 12:
                    controlloMese = "T";
                    break;
                default:
                    controlloMese = "X";
                    break;
            }
            if (Sesso.ToUpper() == "M")
            {
                controlloGiorno = DataNascita.Day.ToString();
            }
            else { controlloGiorno = (DataNascita.Day + 40).ToString(); }
            if (Regex.IsMatch(response.ToUpper(), (@"^[A-Z]{6}[0-9]{2}[A-Z][0-9]{2}[A-Z][0-9]{3}[A-Z]$")) && Cognome.ToUpper().Contains(responseArray[0]) && Cognome.ToUpper().Contains(responseArray[1]) && Cognome.ToUpper().Contains(responseArray[2]) && Nome.ToUpper().Contains(responseArray[3]) && Nome.ToUpper().Contains(responseArray[4]) && Nome.ToUpper().Contains(responseArray[5]) && controlloAnno == (responseArray[6].ToString() + responseArray[7].ToString()) && controlloMese == responseArray[8].ToString() && controlloGiorno == (responseArray[9].ToString() + responseArray[10].ToString()))
            {
                return true;
            }
            else return false;
        }

        public void TaxShow()
        {
            TaxCalculation();
            Console.WriteLine($"==================================================\r\n\r\nCALCOLO DELL'IMPOSTA DA VERSARE:\r\n\r\nContribuente: {Nome} {Cognome}, \r\n\r\nnato il {DataNascita.ToShortDateString()} ({Sesso.ToUpper()}), \r\n\r\nresidente in {ComuneResidenza}, \r\n\r\ncodice fiscale: {CodiceFiscale}\r\n\r\nReddito dichiarato: € {RedditoAnnuale}\r\n\r\nIMPOSTA DA VERSARE: € {Imposte}\r\n\r\n========================================\r\n\r\nGrazie e Arrivederci");
        }

        private void TaxCalculation()
        {
            Console.WriteLine();
            Console.WriteLine("========================================");
            Console.WriteLine();
            Console.WriteLine("Calcolo imposte in corso...");
            Console.WriteLine();
            Console.WriteLine("========================================");
            Console.WriteLine();
            switch (RedditoAnnuale)
            {
                case <= 15000:
                    Imposte = 23 * RedditoAnnuale / 100;
                    break;
                case <= 28000:
                    Imposte = 3450 + ((RedditoAnnuale - 15000) * 27 / 100);
                    break;
                case <= 55000:
                    Imposte = 6960 + ((RedditoAnnuale - 28000) * 38 / 100);
                    break;
                case <= 75000:
                    Imposte = 17220 + ((RedditoAnnuale - 55000) * 41 / 100);
                    break;
                case > 75000:
                    Imposte = 25420 + ((RedditoAnnuale - 75000) * 43 / 100);
                    break;
                default:
                    Console.WriteLine("errore nel calcolo delle imposte");
                    break;
            }
        }
    }
}
