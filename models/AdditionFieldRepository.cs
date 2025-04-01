using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace IdCard.Hanel.Models
{
    public class AdditionFieldRepository
    {
        private readonly AuthenCardDbContext _context;

        public AdditionFieldRepository(AuthenCardDbContext context)
        {
            _context = context;
        }

        // Create a new AdditionConfigField
        public void Create(AdditionField field)
        {
            if (string.IsNullOrEmpty(field.Id))
            {
                field.Id = Guid.NewGuid().ToString(); // Generate a new Id if not provided
            }
            _context.AdditionFields.Add(field);
            _context.SaveChanges();
        }

        // Get the list of all AdditionConfigFields
        public List<AdditionField> GetList()
        {
            return _context.AdditionFields
                           .OrderBy(f => f.SortOrder)
                           .ToList();
        }

        // Get a single AdditionConfigField by Id
        public AdditionField? Get(string id)
        {
            return _context.AdditionFields
                           .FirstOrDefault(f => f.Id == id);
        }

        // Update an existing AdditionConfigField
        public bool Update(string id, AdditionField updatedField)
        {
            var field = Get(id);
            if (field == null) return false;

            field.Type = updatedField.Type;
            field.Value = updatedField.Value;
            field.Require = updatedField.Require;
            field.Label = updatedField.Label;
            field.Notice = updatedField.Notice;
            
            _context.SaveChanges();
            return true;
        }

        // Update the SortOrder of an AdditionConfigField by Id
        public bool UpdateOrder(string id, int newSortOrder)
        {
            var field = Get(id);
            if (field == null) return false;

            field.SortOrder = newSortOrder;
            _context.SaveChanges();
            return true;
        }

        // Delete an AdditionConfigField by Id
        public bool Delete(string id)
        {
            var field = Get(id);
            if (field == null) return false;

            _context.AdditionFields.Remove(field);
            _context.SaveChanges();
            return true;
        }
    }
}
