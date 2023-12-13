using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace AccessibilityModels
{
    public class Ervaringsdeskundige : Gebruiker
    {
        public string Postcode { get; set; }
        
        public string Telefoonnummer { get; set; }

        public string TypeBeperking { get; set; }

        public string Hulpmiddelen { get; set; }
        
        public string AandoeningOfZiekte { get; set; }

        public string VoorkeurBenadering { get; set; }

        public bool MagCommercieelBenaderdWorden { get; set; }

        public List<string> BeschikbareTijden { get; set; }

        public string NaamVoogd { get; set; }

        public string EmailVoogd { get; set; }

        public string TelefoonnummerVoogd { get; set; }

        public ICollection<ErvaringsdeskundigeHulpmiddel> ErvaringsdeskundigeHulpmiddelen { get; set; }

        public DateTime GeboorteDatum { get; set; }

        public int Leeftijd
        {
            get
            {
                return BerekenLeeftijd(GeboorteDatum, DateTime.Now);
            }
        }

        private int BerekenLeeftijd(DateTime geboorteDatum, DateTime huidigeDatum)
        {
            int leeftijd = huidigeDatum.Year - geboorteDatum.Year;

            if (huidigeDatum.Month < geboorteDatum.Month || (huidigeDatum.Month == geboorteDatum.Month && huidigeDatum.Day < geboorteDatum.Day))
            {
                leeftijd--;
            }

            return leeftijd;
        }

    }
}