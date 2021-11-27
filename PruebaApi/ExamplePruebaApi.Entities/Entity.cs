using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamplePruebaApi.Abstractions;
namespace ExamplePruebaApi.Entities
{
    public abstract class Entity : IEntity
    {
        public int id { get; set; }
    }
}
