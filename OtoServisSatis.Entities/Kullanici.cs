using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OtoServisSatis.Entities
{
    public class Kullanici : IEntity
    {
        public int Id { get; set; }

        [StringLength(50)]
        [Display(Name = "Ad"), Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public string Adi { get; set; }

        [StringLength(50), Display(Name = "Soyad"), Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public string Soyadi { get; set; }

        [StringLength(50), Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public string Email { get; set; }
        [StringLength(20)]
        public string? Telefon { get; set; }
        [StringLength(50)]
        [Display(Name = "Kullanıcı Adı")]
        public string? KullaniciAdi { get; set; }

        [Display(Name = "Şifre"), StringLength(50), Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public string Sifre { get; set; }

        [Display(Name = "Aktif mi?")]
        public bool AktifMi { get; set; }

        [Display(Name = "Eklenme Tarihi"), ScaffoldColumn(false)] //Ekranda gözükmesin, elle girmeye gerek yok çünkü otomatiğe bağlandı
        public DateTime? EklenmeTarihi { get; set; } = DateTime.Now; // (= DateTime.Now) Eklenme tarihini otomatiğe bağlandı

        [Display(Name = "Kullanıcı Rolü"), Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public int RolId { get; set; }

        [Display(Name = "Kullanıcı Rolü")]
        public virtual Rol? Rol { get; set; }
    }
}
