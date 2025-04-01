using System;
using System.Linq;

namespace IdCard.Hanel.Models
{
    public class UserRepository
    {
        private readonly AuthenCardDbContext _context;

        public UserRepository(AuthenCardDbContext context)
        {
            _context = context;
        }

        // Create a new user
        public void Create(User user)
        {
            if (_context.Users.Any(u => u.Username == user.Username))
            {
                throw new InvalidOperationException("Username already exists.");
            }

            _context.Users.Add(user);
            _context.SaveChanges();
        }

        // Login a user
        public User? Login(string username, string password)
        {
            try
            {
                return _context.Users.First(u => u.Username == username && u.Password == password);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        // Logout (placeholder, as logout is typically handled client-side)
        public void Logout()
        {
            // No server-side logic for logout in this context
        }

        // Change password for a user
        public void ChangePassword(int userId, string oldPassword, string newPassword)
        {
            var user = _context.Users.First(u => u.Id == userId) ?? throw new InvalidOperationException("User not found.");
            if (user.Password != oldPassword)
            {
                throw new InvalidOperationException("Old password is incorrect.");
            }

            user.Password = newPassword;
            _context.SaveChanges();
        }
    }
}
