using StudentApplication.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApplication.Domain.Services
{
    public interface IDataService<T>
    {
        Task<ICollection<T>> GetAll();
        Task<T> Get(int id);
        Task<T> Update(int id, T entity);
        Task<T> Create(T entity);
        Task<bool> Delete(int id);
        Task<Students> GetByEmail(string email);


    }
}

