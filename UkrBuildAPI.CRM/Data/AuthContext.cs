using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UkrBuildAPI.CRM.Models;

namespace UkrBuildAPI.CRM.Data
{
    public class AuthContext(DbContextOptions options) : IdentityDbContext<User>(options)
    {
    }
}
