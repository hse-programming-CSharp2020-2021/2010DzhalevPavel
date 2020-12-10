using System;
using System.Text;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            
            Console.WriteLine(ConvertHex2Bin1(s));
            
        }

        public static string ConvertHex2Bin1(string HexNumber)
        {
            return Convert.ToString(Convert.ToInt64(HexNumber, 16),2);
        }
        public static string ConvertHex2Bin2(string HexNumber)
        {
            char[] hexSymbols = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F'};
            string[] bin = {"0000", "0001", "0010", "0011", "0100", "0101", "0110", "0111", "1000", "1001", "1010", "1011", "1100", "1101", "1111"}; 
            StringBuilder sb = new StringBuilder();
            return sb.ToString();
            
        }
    }
}