using Demo.DataAccess.Contexts;
using Demo.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Demo.DataAccess.Repo
{
    public class DepartmentRepo(Contexts.AppContext context) : IDepartmentRepo
    {
        private readonly Contexts.AppContext _context = context;//Primary constructor

        //Dependency Injection
        // to make it work i should Register sevices in the startup class[program Services]

        //Contain CRUD Operations   

        //Get ALL 
        public IEnumerable<Department> GetAll(bool WithTracking = false)
        {
            if (WithTracking)
            {
                return _context.Departments.ToList();
            }
            else
            {
                return _context.Departments.AsNoTracking().ToList();
            }
        }
        //Get By ID
        public Department? GetById(int id)
        {
            return _context.Departments.FirstOrDefault(d => d.Id == id);
        }
        //Add
        public int Add(Department department)
        {
            _context.Departments.Add(department);
            return _context.SaveChanges();
        }
        //Update
        public int Edit(Department department)
        {
            _context.Departments.Update(department);
            return _context.SaveChanges();
        }
        //Delete
        public int Delete(Department department)
        {
            _context.Departments.Remove(department);
            return _context.SaveChanges();
        }
    }
}

