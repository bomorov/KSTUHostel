using System.ComponentModel.DataAnnotations;

namespace WebUI.Models.Enums
{
    public enum CoateType
    {
        /// <summary>Область/Город республиканского значения</summary>
        [Display(Name = "Область/Город республиканского значения")]
        RegionAndCity = 1,

        /// <summary>Район/Город областного значения</summary>
        [Display(Name = "Район/Город областного значения")]
        District = 2,

        /// <summary>Айыльный аймак/Город районного значения</summary>
        [Display(Name = "Айыльный аймак/Город районного значения")]
        Countryside = 3,

        /// <summary>Поселок/ПГТ/Село</summary>
        [Display(Name = "Поселок/ПГТ/Село")]
        Village = 4
    }
}