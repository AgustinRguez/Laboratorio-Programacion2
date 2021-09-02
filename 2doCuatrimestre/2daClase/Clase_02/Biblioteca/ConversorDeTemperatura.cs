using System;

namespace Biblioteca
{
    public static class ConversorDeTemperatura
    {
        /*ctrl +r+r para conversion de nombre*/
        /*const se comporta igual que static*/
        private const float ceroAbsoluto = 273.15F;


        /// <summary>
        /// Convierte de celsius a kelvin
        /// </summary>
        /// <param name="temperaturaCelsius"></param>
        /// <returns>La temperatura en grados Kelvin</returns>
        public static float ConvertirCelsiusAKelvin(float temperaturaCelsius)
        {
            float temperaturaKelvin = temperaturaCelsius + ceroAbsoluto;
            
            return temperaturaKelvin;
        }

        /// <summary>
        /// Convierte de kelvin a celsius 
        /// </summary>
        /// <param name="temperaturaKelvin"></param>
        /// <returns>La temperatura en grados Celsius</returns>
        public static float ConvertirKelvinACelsius(float temperaturaKelvin)
        {
            float temperaturaCelsius = temperaturaKelvin - ceroAbsoluto;

            return temperaturaCelsius;
        }
    }           
}
