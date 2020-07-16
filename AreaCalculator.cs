using System;
namespace AreaCalculator
{
    public class AreaCalculator
    {
        /// <summary>
        /// Calculates area of circle by its radius.
        /// </summary>
        /// <param name="radius">radius of circle</param>
        /// <returns>Area of circle</returns>
        public double CalculateArea(double radius)
        {
            if (radius < 0)
                throw new ArgumentException("Radius can't be less than zero");
            return Math.PI * radius * radius;
        }
        /// <summary>
        /// Calculates area of triangle by its sides.
        /// </summary>
        /// <param name="firstSideOfTriangle">Length of first side</param>
        /// <param name="secondSideOfTriangle">Length of second side</param>
        /// <param name="thirdSideOfTriangle">Length of third side</param>
        /// <returns>Area of triangle</returns>
        public double CalculateArea(double firstSideOfTriangle, double secondSideOfTriangle, double thirdSideOfTriangle)
        {
            if (firstSideOfTriangle <= secondSideOfTriangle + thirdSideOfTriangle ||
                secondSideOfTriangle <= firstSideOfTriangle + thirdSideOfTriangle ||
                thirdSideOfTriangle <= firstSideOfTriangle + secondSideOfTriangle)
                throw new ArgumentException("Parameters must be side of triangle");
            double[] sidesOfTriangle = new double[] { firstSideOfTriangle, secondSideOfTriangle, thirdSideOfTriangle };
            Array.Sort(sidesOfTriangle);
            //Third side can be hypotenuse.
            firstSideOfTriangle = sidesOfTriangle[0];
            secondSideOfTriangle = sidesOfTriangle[1];
            thirdSideOfTriangle = sidesOfTriangle[2];
            if (thirdSideOfTriangle * thirdSideOfTriangle == secondSideOfTriangle * secondSideOfTriangle + firstSideOfTriangle * firstSideOfTriangle)
                return firstSideOfTriangle * secondSideOfTriangle / 2;
            else
            {
                double halfPerimeter = (firstSideOfTriangle + secondSideOfTriangle + thirdSideOfTriangle) / 2;
                return Math.Sqrt(halfPerimeter * (halfPerimeter - firstSideOfTriangle) * (halfPerimeter - secondSideOfTriangle) * (halfPerimeter - thirdSideOfTriangle));
            }
        }
    }
}
