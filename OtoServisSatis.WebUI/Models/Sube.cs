using System.ComponentModel.DataAnnotations;

namespace SubeApi.Models
{
    public class Sube
    {
        public int id { get; set; }

        [Display(Name = "Şebe Adı")]
        public string ad { get; set; }

        [Display(Name = "Şehir")]
        public string lokason { get; set; }
    }
}
