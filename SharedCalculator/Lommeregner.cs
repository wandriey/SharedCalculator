using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedCalculator
{
     public class Lommeregner
    {
        /// <summary>
        /// Kan plus tal sammen
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static double plus(double x, double y)
        {
            return x + y;
        }

        /// <summary>
        /// Kan trække to tal fra hinanden. 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static double minus(double x, double y)
        {
            return x - y;
        }

        /// <summary>
        /// Gange to tal sammen. 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static double gange(double x, double y)
        {
            return x * y;
        }

        /// <summary>
        /// Dividere to tal. 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static double division(double x, double y)
        {
            return x / y;
        }
    }
}
