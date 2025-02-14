
namespace PROJECT_S13
{
    internal class Contribuente
    {
        public required string Nome { get; set; }
        public required string Cognome { get; set; }
        public required DateTime DataNascita { get; set; }
        public required string Sesso { get; set; }
        public required string ComuneResidenza { get; set; }
        public required string CodiceFiscale { get; set; }
        public required double RedditoAnnuale { get; set; }

        private void TaxCalculation()
        {
            Console.WriteLine();
            Console.WriteLine("========================================");
            Console.WriteLine();
            Console.WriteLine("Calcolo imposte in corso...");
            Console.WriteLine();
            Console.WriteLine("========================================");
            Console.WriteLine();
            
        }

        private void TaxShow()
        {
            Console.WriteLine("ciao");
        }
    }
}
