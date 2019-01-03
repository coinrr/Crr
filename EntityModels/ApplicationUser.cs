using System;
using Microsoft.AspNetCore.Identity;

namespace Crr.EntityModels
{
    public class ApplicationUser : IdentityUser
    {
        public DateTime MemberSince { get; set; }
    }
}