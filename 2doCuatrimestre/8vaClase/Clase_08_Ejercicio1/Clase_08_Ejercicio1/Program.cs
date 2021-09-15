using System;
using Biblioteca;
namespace Clase_08_Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            VehiculoTerrestre v1 = new Automovil(4, 2, VehiculoTerrestre.Colores.Rojo, 5, 2);
            VehiculoTerrestre v2 = new Camion(6, 2, VehiculoTerrestre.Colores.Blanco,2,1000);
            VehiculoTerrestre v3 = new Moto(2, 0, VehiculoTerrestre.Colores.Negro, 6, 10);
            VehiculoTerrestre v4 = new VehiculoTerrestre(10, 4, VehiculoTerrestre.Colores.Gris,4);
            
        }
    }
}
