
namespace PROJECT_S13
{
    internal class Contribuente
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public DateTime DataNascita { get; set; }
        public char Sesso { get; set; }
        public string ComuneResidenza { get; set; }
        public string CodiceFiscale { get; set; }
        public double RedditoAnnuale { get; set; }

        private void TaxCalculation()
        {
            Console.WriteLine("ciao");
        }

        private void TaxShow()
        {
            Console.WriteLine("ciao");
        }
    }
}
