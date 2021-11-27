using System;
using System.Collections.Generic;

namespace ExamplePruebaApi.Abstractions
{
    public interface ICrud<T>
    {
        //minuto 15
        T Save(T entity); //inserta y actualiza
        IList<T> GetAll();// lista todo
        T GetById(int id); // obtiene uno
        void Delete(int id); // elimina
    }
}
