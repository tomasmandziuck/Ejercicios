using System;

namespace Biblioteca
{
    public static class ConversorDeTemperatura
    {
        private const float ceroAbsoluto = 273.15F;
        /// <summary>
        /// hace la conversion de celcius a kelvin
        /// </summary>
        /// <param name="temperaturaCelsius">el numero de la temperatura en celcius</param>
        /// <returns>la temperatura en kelvin</returns>
        public static float convertirCelciusAKelvin(float temperaturaCelsius)
        {
            float temperaturaKelvin = temperaturaCelsius + ceroAbsoluto;

            return temperaturaKelvin;
        }
        /// <summary>
        /// conversion de kelvin a celcius
        /// </summary>
        /// <param name="temperaturaKelvin">numero de la temperatura en kelvin</param>
        /// <returns>temperatura en celsius</returns>
        public static float convertirKelvinACelsius(float temperaturaKelvin)
        {
            float temperaturaCelsius = temperaturaKelvin - ceroAbsoluto;

            return temperaturaCelsius;
        }
    }
}
