using System.Collections.Generic;
using WebUI.Models.Common;
using WebUI.Models.Enums;
using WebUI.Models.Identity;

namespace WebUI.Models
{
    public class CoateRecord : AuditableEntity
    {
        /// <summary>Конструктор СОАТЕ</summary>
        public CoateRecord()
        {
            Children = new List<CoateRecord>();
            Users = new List<ApplicationUser>();
            Students = new List<Student>();
        }

        /// <summary>Наименование</summary>
        public string Name { get; set; }

        /// <summary>Код</summary>
        public string Code { get; set; }

        /// <summary>Тип СОАТЕ</summary>
        public CoateType CoateType { get; set; }

        /// <summary>FK родителя</summary>
        public int? ParentId { get; set; }

        public CoateRecord Parent { get; set; }

        /// <summary>Порядок следования</summary>
        public int Order { get; set; }

        public IList<CoateRecord> Children { get; set; }
        public IList<ApplicationUser> Users { get; set; }
        public IList<Student> Students { get; set; }
    }
}