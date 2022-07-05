using Microsoft.EntityFrameworkCore;
using StudentApplication.Domain.Model;
using StudentApplication.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApplication.EF.Services
{
    public class GenericDataService<T> : IDataService<T> where T : DomainObject
        
    {
        private readonly SMDbContextFactory _contextFactory;

        public GenericDataService(SMDbContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }
              
        public async Task<T> Create(T entity)
        {
            using (SMDbContext context = _contextFactory.CreateDbContext())
            {
                var createdResult = await context.Set<T>().AddAsync(entity);
                await context.SaveChangesAsync();
                return createdResult.Entity;
            }
        }

        public async Task<T> Get(int id)
        {
            using (SMDbContext context = _contextFactory.CreateDbContext())
            {
                T entity = await context.Set<T>().FirstOrDefaultAsync((e) => e.Id == id);
                return entity;
            }
        }

        public async Task<ICollection<T>> GetAll()
        {
            using (SMDbContext context = _contextFactory.CreateDbContext())
            {
                ICollection<T> entities = await context.Set<T>().ToListAsync();
                return entities;
            }
        }

        public async Task<T> Update(int id, T entity)
        {
            using (SMDbContext context = _contextFactory.CreateDbContext())
            {
                entity.Id = id;
                context.Set<T>().Update(entity);

                await context.SaveChangesAsync();
                return entity;
            }
        }

        public async Task<bool> Delete(int id)
        {
            using (SMDbContext context = _contextFactory.CreateDbContext())
            {
                T entity = await context.Set<T>().FirstOrDefaultAsync((e) => e.Id == id);
                context.Set<T>().Remove(entity);
                await context.SaveChangesAsync();
                return true;
            }
        }

        public async Task<Students> GetByEmail(string email)
        {
            using (SMDbContext context = _contextFactory.CreateDbContext())
            {
                Students entity = await context.Students.FirstOrDefaultAsync((e) => e.Email == email);
                return entity;
            }

        }

        public List<Grades>GetGrades(int idStudent)
        {
            using (SMDbContext context = _contextFactory.CreateDbContext())
            {
                List<Grades> entity = context.Grades.Where(g => g.StudentId == idStudent).ToList();

                return entity;
            }
        }

        public List<Courses> GetCourses()
        {
            using (SMDbContext context = _contextFactory.CreateDbContext())
            {


               List<Courses> entity = context.Courses.ToList();

                return entity;
            }
        }

        public  List<Tests> GetTests()
        {
            using (SMDbContext context = _contextFactory.CreateDbContext())
            {
                List<Tests> entity =  context.Tests.ToList();
                return entity;
            }
        }


    }
}
