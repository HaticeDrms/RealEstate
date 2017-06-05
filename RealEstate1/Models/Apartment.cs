using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstate1.Models
{
    public class Apartment:BaseEntity
    {
        [Display(Name = "Müşterinin Adı Soyadı")]
        [StringLength(100)]
        public string Name { get; set; }
        [Display(Name = "Proje Adı")]
        [ForeignKey("ProjectId")]
        public long ProjectId { get; set; }
        public virtual Project Project { get; set; }
        [Required]
        [Display(Name = "Rezerve edilmiş mi?")]
        public bool IsFull { get; set; }
        [Required(ErrorMessage = "Kaçıncı kat alanı boş bırakılamaz.")]
        [Display(Name = "Kaçıncı Kat")]
        public int Floor { get; set; }
        [Required(ErrorMessage = "Daire numarası alanı boş bırakılamaz.")]
        [Display(Name = "Daire Numarası")]
        public int RoomNumber { get; set; }
        [Required(ErrorMessage = "Oda sayısı alanı boş bırakılamaz.")]
        [Display(Name = "Oda Sayısı")]
        public int RoomCount { get; set; }
        [Required(ErrorMessage = "Fiyat aralığı alanı boş bırakılamaz.")]
        [Display(Name = "Fiyat Aralığı")]
        public string Price { get; set; }
        [Required]
        [Display(Name = "Daire Genişliği")]
        public string Size { get; set; }
    }
}
