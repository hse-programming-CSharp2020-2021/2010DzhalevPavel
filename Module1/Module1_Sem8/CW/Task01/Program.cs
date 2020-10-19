using System;

namespace Task01
{
    class Program
    {
        /// <summary>
        /// In this lesson we will be looking at exceptions.
        /// The try-catch approach is mandatory when working with files!
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            try
            {
                //Provide test case for exceptions.
                int n = int.Parse("3894602893659328745634");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("ArgumentNullException!");
            }
            catch (FormatException)
            {
                Console.WriteLine("FormatException!");
            }
            //Exceptions are objects with much information.
            //More general exceptions should be located lower than more specific ones.
            catch (Exception ex)
            {
                Console.WriteLine("Exception!" + ex.Message + "\n" + ex.Source);
            }
            //This block is not mandatory and is always executed.
            finally
            {
                Console.WriteLine("!!!");
            }
            
            

        }
    }
}