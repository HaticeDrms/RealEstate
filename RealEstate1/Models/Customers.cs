using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstate1.Models
{
    public class Customers:BaseEntity
    {
        [Required(ErrorMessage = "Müşterinin Adı Soyadı alanı boş bırakılamaz.")]
        [Display(Name = "Müşterinin Adı Soyadı")]
        [StringLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Telefon Numarası alanı boş bırakılamaz.")]
        [Display(Name = "Cep Telefonu")]
        [StringLength(20)]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Adres alanı boş bırakılamaz.")]
        [Display(Name = "Adres")]
        [StringLength(200)]
        public string Address { get; set; }

        [Required(ErrorMessage = "T.C Kimlik No alanı boş bırakılamaz.")]
        [Display(Name = "T.C Kimlik No")]
        [StringLength(20)]
        public string IdentityNumber { get; set; }

    }
}
