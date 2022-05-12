using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class UserContext : IDB<User, int>
    {
        private ExamDBContext _context;
        public UserContext(ExamDBContext context)
        {
            this._context = context;
        }

        public void Create(User item)
        {
            try
            {
                _context.Users.Add(item);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Delete(int key)
        {
            try
            {
                User playerFromDB = Read(key);
                _context.Remove(playerFromDB);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Delete(User pleyerche)
        {
            try
            {
                _context.Users.Remove(pleyerche);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public User Read(int key)
        {
            try
            {
                return _context.Users.Find(key);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IEnumerable<User> ReadAll()
        {
            try
            {
                return _context.Users.ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Update(User item)
        {
            try
            {
                User playerFromDB = Read(item.ID);

                _context.Entry(playerFromDB).CurrentValues.SetValues(item);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
