using ExamplePruebaApi.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
namespace ExamplePruebaApi.DataAccess
{
    public class DBContext<T> : IDbContext<T> where T : IEntity // nos permite adaptar nuestro proovedor de datos
        //si es entity framework o adonet
    {
        IList<T> data;

        public DBContext()
        {
            data = new List<T>();
        }
        public void Delete(int id)
        {
            var e = data.Where(u => u.id.Equals(id)).FirstOrDefault(); //busco al objeto en la coleccion y si lo encuentra lo elimina
            if( e!= null)
            {
                data.Remove(e);
            }
        }

        public IList<T> GetAll()
        {
            return data;
        }

        public T GetById(int id) //devuelve un objeto de la lista o sino devuelve null
        {
            return data.Where(e => e.id.Equals(id)).FirstOrDefault();
        }

        public T Save(T entity)
        {
            if(entity.id.Equals(0))
            {
                data.Add(entity);
            }
            else
            {
                
            }
            return entity;
        }
    }
}
