
namespace PROJECT_S13
{
    internal class Contribuente
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public DateTime DataNascita { get; set; }
        public string Sesso { get; set; }
        public string ComuneResidenza { get; set; }
        public string CodiceFiscale { get; set; }
        public double RedditoAnnuale { get; set; }
        public double Imposte {  get; set; }

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
                    Imposte = 3450 + ((RedditoAnnuale - 15000) * 27/ 100);
                    break;
                case <= 55000:
                    Imposte = 6960 + ((RedditoAnnuale - 28000) * 38/ 100);
                    break;
                case <= 75000:
                    Imposte = 17220 + ((RedditoAnnuale - 55000)*41/100);
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
