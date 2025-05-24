using CareNet_System.Models;
using CareNet_System.Repository;

namespace CareNet_System.Repostatory
{
    public class DepartmentRepository : IRepository<Department>
    {
        HosPitalContext context;
        public DepartmentRepository(HosPitalContext cnt)
        {
            context = cnt;
        }

        public void Add(Department obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Department> GetAll()
        {
            return context.Departments.ToList();
        }
        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(Department obj)
        {
            context.Departments.Update(obj);

        }
    }
}

