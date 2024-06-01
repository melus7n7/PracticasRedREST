using backendnet.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace backendnet.Data.Seed;

public static class SeedIdentityUserData
{
    public static void SeedUserIdentityData(this ModelBuilder modelBuilder){
        string AdministradorRoleId = Guid.NewGuid().ToString();
        modelBuilder.Entity<IdentityRole>().HasData( new IdentityRole {
            Id = AdministradorRoleId, Name = "Administrador", NormalizedName = "Administrador".ToUpper()
        });

        string UserRoleId = Guid.NewGuid().ToString();
        modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole{
            Id = UserRoleId, Name = "Usuario", NormalizedName = "Usuario".ToUpper()
        });

        string UsuarioId = Guid.NewGuid().ToString();
        modelBuilder.Entity<CustomIdentityUser>().HasData(new CustomIdentityUser{
            Id = UsuarioId, UserName = "gvera@uv.mx", NormalizedUserName = "gvera@uv.mx".ToUpper(),
            Email = "gvera@uv.mx", Nombre = "Guillermo Humberto Vera Amaro", NormalizedEmail = "gvera@uv.mx".ToUpper(),
            PasswordHash = new PasswordHasher<CustomIdentityUser>().HashPassword(null!, "patito"),
            Protegido = true
        });

        modelBuilder.Entity<IdentityUserRole<string>>().HasData( new IdentityUserRole<string>{
            RoleId = AdministradorRoleId, UserId = UsuarioId
        });

        string UsuarioId2 = Guid.NewGuid().ToString();
        modelBuilder.Entity<CustomIdentityUser>().HasData(new CustomIdentityUser{
            Id = UsuarioId2, UserName = "patito@uv.mx", NormalizedUserName = "patito@uv.mx".ToUpper(),
            Email = "patito@uv.mx", Nombre = "Usuario patito", NormalizedEmail = "patito@uv.mx".ToUpper(),
            PasswordHash = new PasswordHasher<CustomIdentityUser>().HashPassword(null!, "patito")        });

        modelBuilder.Entity<IdentityUserRole<string>>().HasData( new IdentityUserRole<string>{
            RoleId = UserRoleId, UserId = UsuarioId2
        });
    }
}