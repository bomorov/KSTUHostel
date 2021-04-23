using System.ComponentModel.DataAnnotations;
using WebUI.Models.Common;

namespace WebUI.Models
{
    public class Hostel : BaseDictEntity
    {
        [Display(Name = "Этажность")]
        public int Flooring { get; set; }

        [Display(Name = "Проектная мощность")]
        public string Capacity { get; set; }

        [Display(Name = "Количество жилых комнат")]
        public int LivingRoomCount { get; set; }

        [Display(Name = "Количество мест общественного назначения")]
        public int ServiceRoomCount { get; set; }

        [Display(Name = "Карта здания")]
        public string Map { get; set; }

        [Display(Name = "Количество помещений служебного назначения.")]
        public int OfficeRoomCount { get; set; }
    }
}