using Domain.Enum;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entity.Login
{
    public class ApplicationUser : IdentityUser
    {
        public long? TenentId { get; set; }
        public UserType UserType { get; set; }
    }
}
