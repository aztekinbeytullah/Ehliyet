using DAL.Concrete;
using Entity.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace WebIU
{
    public class IdentityInitializer
    {
        static IUserStore<AppUser> _store = new UserStore<AppUser>(new MyDbContext());
        static UserManager<AppUser> _userManager = new UserManager<AppUser>(_store, null, new PasswordHasher<AppUser>(), null, null, null, null, null, null);

        static RoleManager<IdentityRole> _roleManager = new RoleManager<IdentityRole>(
            new RoleStore<IdentityRole>(new MyDbContext()), null, null, null, null);



        public IdentityInitializer(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager=userManager;
            _roleManager=roleManager;
        }

        public static void CreateAdmin()
        {
            // Kullanıcı Örneği Oluşturuldu
            AppUser appUser = new AppUser
            {
                Name = "Beytullah",
                Surname = "Aztekin",
                UserName = "beytullah",

            };
            
            ///Kullanıcı Örneği Dbden kontrol edildi yoksa Eklendi
            if (_userManager.FindByNameAsync("Beytullah").Result==null)
            {
                var IdentityResult = _userManager.CreateAsync(appUser, "1").Result;
            }

            //Söz konusu kulanıcısya ilgili admin rolu Eklendi
            if (_roleManager.FindByNameAsync("Admin").Result==null)
            {
                var roleResult = _roleManager.CreateAsync(new IdentityRole
                {
                    Name ="Admin"

                }).Result;

                var result = _userManager.AddToRoleAsync(appUser, "Admin").Result;
            }


        }
    }
}
