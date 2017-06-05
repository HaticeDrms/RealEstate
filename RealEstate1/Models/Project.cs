using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstate1.Models
{
    public class Project : BaseEntity
    {

        [Required(ErrorMessage = "Proje adı alanı boş bırakılamaz.")]
        [Display(Name = "Proje Adı")]
        [StringLength(100)]
        public string ProjectName { get; set; }
        [Required(ErrorMessage = "Firma adı alanı boş bırakılamaz.")]
        [Display(Name = "Firma Adı")]
        [StringLength(100)]
        public string CompanyName { get; set; }
        [Required(ErrorMessage = "Kat sayısı alanı boş bırakılamaz.")]
        [Display(Name = "Kat Sayısı")]
        public int FloorCount { get; set; }
        [Required(ErrorMessage = "Daire sayısı alanı boş bırakılamaz.")]
        [Display(Name = "Daire Sayısı")]
        public int ApartmentCount { get; set; }

    }
}
