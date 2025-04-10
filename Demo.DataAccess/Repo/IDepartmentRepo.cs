using Demo.DataAccess.Models;

namespace Demo.DataAccess.Repo
{
    public interface IDepartmentRepo
    {
        int Add(Department department);
        int Delete(Department department);
        int Edit(Department department);
        IEnumerable<Department> GetAll(bool WithTracking = false);
        Department? GetById(int id);
    }
}