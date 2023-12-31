﻿using Humanizer;
using tallerAPI.Data.Enumerations;

namespace tallerAPI.Data
{
    public class SeedDb
    {
        private readonly tallerDBContext context;
        private readonly Random random;

        public SeedDb(tallerDBContext context)
        {
            this.context = context;
            this.random = new Random();
        }

        public async Task SeedAsync()
        {
            await this.context.Database.EnsureCreatedAsync();

            if (!this.context.Clients.Any())
            {
                this.AddClient("First Client");
                this.AddClient("Second Client");
                this.AddClient("Third Client");
                await this.context.SaveChangesAsync();
            }

            if (!this.context.UserRoles.Any())
            {
                this.AddUserRole("Administrator", RoleType.SuperAdmin);
                this.AddUserRole("Staff", RoleType.Staff);
                this.AddUserRole("Guest", RoleType.Guest);
                await this.context.SaveChangesAsync();
            }

            if (!this.context.Users.Any())
            {
                this.AddUser("AdminUser", "123", 1);
                this.AddUser("StaffUser", "123", 2);
                this.AddUser("GuestUser", "123", 3);
                await this.context.SaveChangesAsync();
            }

            if (!this.context.Vehicles.Any())
            {
                this.AddVehicle("Automovil", "Stepway", "Renault", 2021, "JSR922");
                this.AddVehicle("Motocicleta", "Vstrom 650", "Suzuki", 2013, "WBX77C");
                await this.context.SaveChangesAsync();
            }

        }

        private void AddClient(string name)
        {
            this.context.Clients.Add(new Models.Client
            {
                Name = name,
                Dna = this.random.Next(1000000, 1999999).ToString()
            });
        }
        private void AddUserRole(string roleName, RoleType roleType)
        {
            this.context.UserRoles.Add(new Models.UserRole
            {
                Name = roleName,
                Type = roleType
            });
        }

        private void AddUser(string userId, string password, long userRoleId)
        {
            this.context.Users.Add(new Models.User
            {
                UserName = userId,
                Password = password,
                RoleId = userRoleId
            });
        }

        private void AddVehicle(string vehicleType, string vehicleName, string vehicleBrand, int vehicleModel, string vehiclePlaque)
        {
            this.context.Vehicles.Add(new Models.Vehicle
            {
                VehicleType = vehicleType,
                VehicleName = vehicleName,
                VehicleBrand = vehicleBrand,
                VehicleModel = vehicleModel,
                VehiclePlaque = vehiclePlaque
            });
        }


    }

}