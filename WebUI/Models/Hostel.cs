using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models.Common;

namespace WebUI.Models
{
    public class Hostel:BaseDictEntity
    {
        [Display(Name = "Этажность")]
        public int Flooring { get; set; }

        [Display(Name = "Проектная мощность")]
        public string Capacity { get; set; }

        [Display(Name = "Количество жилых комнат")]
        public int LivingRoomCount { get; set; }

        [Display(Name = "Количество жилых комнат")]
        public string Map { get; set; }
    }
}
