using CareNet_System.Models;
using CareNet_System.Repository;

namespace CareNet_System.Repostatory
{
    public class StaffRepository:IRepository<Staff>
    {
        HosPitalContext context;
        public StaffRepository(HosPitalContext cnt)
        {
            context = cnt;
        }
        public void Add(Staff obj)
        {
            throw new NotImplementedException();
        }
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
        public List<Staff> GetAll()
        {
            return context.Staff.ToList();
        }
        public void Save()
        {
            context.SaveChanges();
        }
        public void Update(Staff obj)
        {
            throw new NotImplementedException();
        }
    }
    
    
}
