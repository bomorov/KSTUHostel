using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Mapings;

namespace WebUI.Models.DTOs
{
    public class StudentDto:IMapFrom<Student>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string MidlleName { get; set; }
        public string FullName { get; set; }

        public string PassportDta { get; set; }

        /// <summary>FK область</summary>
        [Display(Name = "Место постоянной прописки: Область")]
        public int RegionOrCityId { get; set; }

        public CoateRecord RegionOrCity { get; set; }

        /// <summary>FK район</summary>
        [Display(Name = "Место постоянной прописки: Район")]
        public int DistrictOrCityId { get; set; }

        public CoateRecord DistrictOrCity { get; set; }

        /// <summary>FK аймак</summary>
        [Display(Name = "Место постоянной прописки: Аймак")]
        public int? CountrysideOrCityId { get; set; }

        public CoateRecord CountrysideOrCity { get; set; }

        /// <summary>FK село</summary>
        [Display(Name = "Место постоянной прописки: Село")]
        public int? VillageId { get; set; }

        public CoateRecord Village { get; set; }

        /// <summary>Улица</summary>
        [Display(Name = "Место постоянной прописки: Улица")]
        public string Street { get; set; }

        /// <summary>Дом</summary>
        [Display(Name = "Место постоянной прописки: Дом")]
        public string House { get; set; }

        /// <summary>Квартира</summary>
        [Display(Name = "Место постоянной прописки: Квартира")]
        public string Flat { get; set; }

        [Display(Name = "Фотография")]
        public string Path { get; set; }
    }
}
