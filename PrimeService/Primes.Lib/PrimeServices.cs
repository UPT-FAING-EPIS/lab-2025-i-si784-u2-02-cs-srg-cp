using System;

namespace Primes.Lib
{
    /// <summary>
    /// Proporciona servicios relacionados con números primos.
    /// </summary>
    public class PrimeService
    {
        /// <summary>
        /// Determina si un número entero es primo.
        /// </summary>
        /// <param name="candidate">El número entero a evaluar.</param>
        /// <returns>
        /// <c>true</c> si el número es primo; de lo contrario, <c>false</c>.
        /// </returns>
        public bool IsPrime(int candidate)
        {
            if (candidate < 2)
                return false;

            for (int i = 2; i <= Math.Sqrt(candidate); i++)
            {
                if (candidate % i == 0)
                    return false;
            }

            return true;
        }
    }
}
