using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace WebUI.Models.Identity
{
    public class ApplicationUserRole: IdentityUserRole<int>
    {
        /// <summary>FK роли</summary>
        public override int RoleId { get; set; }
        public virtual ApplicationRole Role { get; set; }

        /// <summary>FK пользователя</summary>
        public override int UserId { get; set; }
        public virtual ApplicationUser User { get; set; }

    }
}
