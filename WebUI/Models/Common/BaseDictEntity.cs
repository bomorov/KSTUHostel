using System.ComponentModel.DataAnnotations;

namespace WebUI.Models.Common
{
    public abstract class BaseDictEntity
    {
        /// <summary>PK</summary>
        public int Id { get; set; }

        /// <summary>Наименование</summary>
        [Display(Name = "Наименование")]
        public string Name { get; set; }
    }
}