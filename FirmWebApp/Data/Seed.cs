using FirmWebApp.Models;

namespace FirmWebApp.Data
{
    public class Seed
    {
        public static void SeedData(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();

                context.Database.EnsureCreated();

                //Layouts
                /*if (!context.Layouts.Any())
                {
                    context.Layouts.AddRange(new List<Layout>()
                    {
                        new Layout()
                        {
                            Code = "Code_Layout0101_BigMachines",
                            Name = "Layout0101",
                            Width = 100.50,
                            Height = 200
                        },
                        new Layout()
                        {
                            Code = "Code_Layout0202_BigMachines",
                            Name = "Layout0202",
                            Width = 150.50,
                            Height = 150.50
                        }
                    });
                    context.SaveChanges();
                }*/

                // Recherche des objets Layout existants dans la base de données
                /*Layout layout1 = context.Layouts.FirstOrDefault(l => l.Code == "Code_Layout0101_BigMachines");
                Layout layout2 = context.Layouts.FirstOrDefault(l => l.Code == "Code_Layout0202_BigMachines");*/
                Layout layout1 = new Layout()
                {
                    Code = "Code_Layout0101_BigMachines",
                    Name = "Layout0101",
                    Width = 100.50,
                    Height = 200
                };
                Layout layout2 = new Layout()
                {
                    Code = "Code_Layout0202_BigMachines",
                    Name = "Layout0202",
                    Width = 150.50,
                    Height = 150.50
                };

                //Pour charger les donnes de l'object Layout 
                //var machines = context.Machines.Include(m => m.Layout).ToList();
                //Machines
                if (!context.Machines.Any())
                {
                    context.Machines.AddRange(new List<Machine>()
                    {
                        new Machine()
                        {
                            Code = "Code0101",
                            Name = "Machine0101",
                            Layout = layout1,
                            /*Layout = new Layout() {
                                Code = "Code_Layout0101_BigMachines",
                                Name = "Layout0101",
                                Width = 100.50,
                                Height = 200
                            },*/
                            Width = 100,
                            Height = 150,
                            PositionX = 0,
                            PositionY = 2,
                            RunningStatus = true,
                            Info1 = "info1",
                            Info2 = "info2"
                        },
                        new Machine()
                        {
                            Code = "Code0202",
                            Name = "Machine0202",
                            Layout = layout1,
                            Width = 100,
                            Height = 150,
                            PositionX = 4,
                            PositionY = 5,
                            RunningStatus = true,
                            Info1 = "info1",
                            Info2 = "info2"
                        },
                        new Machine()
                        {
                            Code = "Code0303",
                            Name = "Machine0303",
                            Layout = layout1,
                            Width = 100,
                            Height = 150,
                            PositionX = 0,
                            PositionY = 2,
                            RunningStatus = true,
                            Info1 = "info1",
                            Info2 = "info2"
                        },
                        new Machine()
                        {
                            Code = "Code0404",
                            Name = "Machine0404",
                            Layout = layout2,
                            Width = 100,
                            Height = 150,
                            PositionX = 4,
                            PositionY = 5,
                            RunningStatus = true,
                            Info1 = "info1",
                            Info2 = "info2"
                        },
                        new Machine()
                        {
                            Code = "Code0505",
                            Name = "Machine0505",
                            Layout = layout2,
                            Width = 100,
                            Height = 150,
                            PositionX = 0,
                            PositionY = 2,
                            RunningStatus = true,
                            Info1 = "info1",
                            Info2 = "info2"
                        },
                        new Machine()
                        {
                            Code = "Code0606",
                            Name = "Machine0606",
                            Layout = layout2,
                            Width = 100,
                            Height = 150,
                            PositionX = 4,
                            PositionY = 5,
                            RunningStatus = true,
                            Info1 = "info1",
                            Info2 = "info2"
                        }
                    });
                    context.SaveChanges();
                }
            }
        }

        /*public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                //Roles
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
                if (!await roleManager.RoleExistsAsync(UserRoles.User))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

                //Users
                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<AppUser>>();
                string adminUserEmail = "teddysmithdeveloper@gmail.com";

                var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
                if (adminUser == null)
                {
                    var newAdminUser = new AppUser()
                    {
                        UserName = "teddysmithdev",
                        Email = adminUserEmail,
                        EmailConfirmed = true,
                        Address = new Address()
                        {
                            Street = "123 Main St",
                            City = "Charlotte",
                            State = "NC"
                        }
                    };
                    await userManager.CreateAsync(newAdminUser, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
                }

                string appUserEmail = "user@etickets.com";

                var appUser = await userManager.FindByEmailAsync(appUserEmail);
                if (appUser == null)
                {
                    var newAppUser = new AppUser()
                    {
                        UserName = "app-user",
                        Email = appUserEmail,
                        EmailConfirmed = true,
                        Address = new Address()
                        {
                            Street = "123 Main St",
                            City = "Charlotte",
                            State = "NC"
                        }
                    };
                    await userManager.CreateAsync(newAppUser, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
                }
            }
        }*/
    }
}