using Microsoft.EntityFrameworkCore;
using System;
using IdCard.Hanel_obj.auxi;

namespace IdCard.Hanel.Models
{
    public class AuthenCardDbContext : DbContext
    {
        private static AuthenCardDbContext? _instance;
        private static readonly object _lock = new();

        public static AuthenCardDbContext Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            var databasePath = AppConfig.Instance.GetDatabasePath();
                            var options = new DbContextOptionsBuilder<AuthenCardDbContext>()
                                .UseSqlite($"Data Source={databasePath}")
                                .Options;
                            _instance = new AuthenCardDbContext(options);

                            // Ensure database is created and migrations are applied
                            _instance.EnsureDatabaseUpdated();

                            // Initialize default user if no user exists
                            _instance.InitializeDefaultUser();

                            // Initialize default AdditionFields if none exist
                            _instance.InitializeDefaultAdditionFields();
                        }
                    }
                }
                return _instance;
            }
        }

        private AuthenCardDbContext(DbContextOptions<AuthenCardDbContext> options) : base(options) { }


        public DbSet<User> Users { get; set; } = null!;
        public DbSet<InOutLog> InOutLogs { get; set; } = null!;
        public DbSet<Customer> Customer { get; set; } = null!;
        public DbSet<AdditionField> AdditionFields { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var databasePath = AppConfig.Instance.GetDatabasePath();
                optionsBuilder.UseSqlite($"Data Source={databasePath}");
            }
        }

        private void EnsureDatabaseUpdated()
        {
            try
            {
                Console.WriteLine("Ensuring database is created...");
                if (Database.EnsureCreated()) // Ensure the database and tables are created
                {
                    Console.WriteLine("Database and tables created successfully.");
                }
                else
                {
                    Console.WriteLine("Database already exists. Applying migrations...");
                    Database.Migrate(); // Apply migrations programmatically
                    Console.WriteLine("Migrations applied successfully.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error ensuring database is updated: {ex.Message}");
                throw;
            }
        }

        private void InitializeDefaultUser()
        {
            if (!Users.Any())
            {
                Users.Add(new User
                {
                    Username = "admin",
                    Password = "admin", // Default password (should be hashed in a real application)
                });
                SaveChanges();
            }
        }

        private void InitializeDefaultAdditionFields()
        {
            if (!AdditionFields.Any())
            {
                AdditionFields.AddRange(new[]
                {
                    new AdditionField { Id = "field1", Require = true, Label = "Khu Vực Tầng", Notice = "", SortOrder = 1, Type = AdditionFieldType.Text },
                    new AdditionField { Id = "field2", Require = false, Label = "Phòng ban", Notice = "", SortOrder = 1, Type = AdditionFieldType.Text },
                    new AdditionField {
                        Id = "field3",
                        Require = true,
                         Label = "Mục đích",
                         Value = "Thăm thân; Công tác; Khách hàng; Đối tác; Khác",
                          Notice = "" , SortOrder = 1, Type = AdditionFieldType.Dropdrown }
                });
                SaveChanges();
            }
        }
    }
}
