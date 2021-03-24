using System;

namespace MagicCity
{
    /// <summary>
    /// This is a class type, containing all details about each street and its houses.
    /// </summary>
    public class Street
    {
        public string Name { get; set; }
        public int[] Houses { get; set; }

        public static int operator ~(Street street) => street.Houses.Length;

        public static bool operator -(Street street)
        {
            foreach (var house in street.Houses)
            {
                if (house == 7) return true;
            }

            return false;
        }

        public override string ToString()
        {
            string result = $"{Name} ";
            foreach (var house in Houses)
            {
                result += $"{house} ";
            }

            return result;
        }
    }
}