using System;
using System.Collections.Generic;
using ExamplePruebaApi.Abstractions;
using ExamplePruebaApi.Repository;

namespace ExamplePruebaApi.Application
{
    public interface IApplication<T> : ICrud<T>
    {
    }
    public class Application<T> : IApplication<T> where T: IEntity //solo van a poder ingresar a la capa aplicacion 
        //objetos que sean del tipo IEntity
    {
        IRepository<T> repository;
        public Application(IRepository<T> repository)
        {
            this.repository = repository;
        }
        public void Delete(int id)
        {
            repository.Delete(id);
        }

        public IList<T> GetAll()
        {
            return repository.GetAll();
        }

        public T GetById(int id)
        {
            return repository.GetById(id);
        }

        public T Save(T entity)
        {
            return repository.Save(entity);
        }
    }
}
