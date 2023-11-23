using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreCSharp.Keywords
{
    /// <summary>
    /// Keywords used: try, catch, throw, finally
    /// </summary>
    public class ExceptionHandlingKW
    {
        public ExceptionHandlingKW() { }


        public static void StarterExHandling()
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw new Exception(); //or throw;In this case ex is returned to the called method
            }
            finally//Executed always irrespective of catch block
            {

            }
        }

    }
}
