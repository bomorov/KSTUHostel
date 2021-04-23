using AutoMapper;
using System.ComponentModel.DataAnnotations;
using WebUI.Mapings;

namespace WebUI.Models.DTOs
{
    public class HostelDto : IMapFrom<Hostel>
    {
        [Display(Name = "Название")]
        public string Name { get; set; }

        [Display(Name = "Этажность")]
        public int Flooring { get; set; }

        [Display(Name = "Проектная мощность")]
        public string Capacity { get; set; }

        [Display(Name = "Количество жилых комнат")]
        public int LivingRoomCount { get; set; }

        [Display(Name = "Количество мест общественного назначения")]
        public string ServiceRoomCount { get; set; }

        [Display(Name = "Карта здания")]
        public string Map { get; set; }

        [Display(Name = "Количество помещений служебного назначения.")]
        public string OfficeRoomCount { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Hostel, HostelDto>();
        }
    }
}