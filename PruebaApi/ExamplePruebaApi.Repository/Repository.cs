using ExamplePruebaApi.Abstractions;
using System;
using System.Collections.Generic;

namespace ExamplePruebaApi.Repository
{
    public interface IRepository<T> : ICrud<T>
    {

    }
    public class Repository<T> : IRepository<T> where T : IEntity
    {
        IDbContext<T> contexto;
        public Repository(IDbContext<T> context) //inyectamos contexto
            //pasamanos de abstracciones para generar un desacoplamiento
        {
            this.contexto = context;
        }
        public void Delete(int id)
        {
            contexto.Delete(id);
        }

        public IList<T> GetAll()
        {
            return contexto.GetAll();
        }

        public T GetById(int id)
        {
            return contexto.GetById(id);
        }

        public T Save(T entity)
        {
            return contexto.Save(entity);
        }
    }
}
