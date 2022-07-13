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

        public  List<GradeTestsCourses>GetGradesTestsCourses(int idStudent)
        {
            using (SMDbContext context = _contextFactory.CreateDbContext())
            {
                var data = context.Grades
                    .Join(
                        context.Tests,
                        grade => grade.TestId,
                        test => test.Id,
                        (grade, test) => new
                        { StudentId = grade.StudentId, GradeValue = grade.GradeValue, TestNote = test.Note, CourseId = test.CourseId })
                    .Join(
                        context.Courses,
                        test => test.CourseId,
                        course => course.Id,
                        (test, course) => new GradeTestsCourses { 
                            StudentId = test.StudentId, GradeValue = test.GradeValue, TestNote = test.TestNote, CourseName = course.CourseName }
                        );

                var entity = data.Where(d => d.StudentId == idStudent).ToList();
                return entity;

            }
        }

        public List<Courses> GetCourses(int idStudent)
        {
            using (SMDbContext context = _contextFactory.CreateDbContext())
            {
                int idstudy = context.Students.Where(s => s.Id == idStudent).FirstOrDefault<Students>().StudyId;
                List<Courses> entity = context.Courses.Where(s=>s.StudyId==idstudy).ToList();
                return entity;
            }
        }

        public List<TestsCourses> GetTestsCourses(int idStudent)
        {
            using (SMDbContext context = _contextFactory.CreateDbContext())
            {
                int idstudy=context.Students.Where(s => s.Id == idStudent).FirstOrDefault<Students>().StudyId;

                var data = context.Tests
                    .Join(
                        context.Courses,
                        test => test.CourseId,
                        course => course.Id,
                        (test, course) => new TestsCourses{ 
                            CourseName = course.CourseName, testNote = test.Note, TestDate = test.Date, StudyId = test.StudyId }
                    );

                var entity = data.Where(d => d.StudyId == idstudy).ToList();
                return entity;
            }
        }

      
    }
}
