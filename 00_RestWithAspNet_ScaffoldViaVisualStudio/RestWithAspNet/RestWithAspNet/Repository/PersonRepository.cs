using RestWithAspNet.Model;
using RestWithAspNet.Model.Context;
using RestWithAspNet.Repository.Generic;
using System.Collections.Generic;
using System.Linq;

namespace RestWithAspNet.Repository
{
    public class PersonRepository : GenericRepository<Person>, IPersonRepository
    {
        public PersonRepository(MySQLContext context) : base(context)
        {
        }

        public Person Disable(long id)
        {
            if (!_context.People.Any(p => p.Id.Equals(id))) return null;
            var user = _context.People.SingleOrDefault(p => p.Id.Equals(id));

            if (user != null)
            {
                user.Enabled = false;
                _context.Entry(user).CurrentValues.SetValues(user);
                _context.SaveChanges();
            }
            return user;
        }

        public List<Person> FindByName(string firstName, string secondName)
        {
            if (!string.IsNullOrWhiteSpace(firstName) && !string.IsNullOrWhiteSpace(secondName))
            {
                return _context.People.Where(
                    p => p.FirstName.Contains(firstName)
                    && p.LastName.Contains(secondName)).ToList();
            }
            else if (string.IsNullOrWhiteSpace(firstName) && !string.IsNullOrWhiteSpace(secondName))
            {
                return _context.People.Where(
                    p => p.LastName.Contains(secondName)).ToList();
            }
            else if (!string.IsNullOrWhiteSpace(firstName) && string.IsNullOrWhiteSpace(secondName))
            {
                return _context.People.Where(
                    p => p.FirstName.Contains(firstName)).ToList();
            }
            return null;
        }
    }
}
