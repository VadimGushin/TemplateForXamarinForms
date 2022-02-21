using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateXamarinForms.Interfaces.SqlServices
{
    public interface IBaseSqlService<T> where T : class, new()
    {
        bool Insert(T item);
        bool Insert(IEnumerable<T> item);
        IEnumerable<T> GetAll();
        bool Delete(T item);
        bool Delete(IEnumerable<T> item);
        bool Update(T item);
        bool Cleane();
    }
}
