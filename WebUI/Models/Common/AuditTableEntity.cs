using System;

namespace WebUI.Models.Common
{
    /// <summary>Базовый класс для аудита</summary>
    public abstract class AuditableEntity : BaseEntity
    {
        /// <summary>Создано пользователем ID</summary>
        public int CreatedBy { get; set; }

        /// <summary>Дата создания записи</summary>
        public DateTime Created { get; set; }

        /// <summary>Обновлено пользователем ID</summary>
        public int? LastModifiedBy { get; set; }

        /// <summary>Дата последнего обновления записи</summary>
        public DateTime? LastModified { get; set; }
    }
}