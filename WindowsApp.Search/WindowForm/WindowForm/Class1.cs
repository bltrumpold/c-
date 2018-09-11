using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationClass
{
    public class ClassValidation
    {
        public static bool BadWords(string temp)
        {
            bool result = false;

            string[] strbadWords = { "poop", "loser", "idiot", "dummy" };

            foreach (string BW in strbadWords)

                if (temp.Contains(BW))
                {
                    result = true;
                }

            return result;
        } // end of bad words validation ----------------------------------------------------------------------------

        public static bool FilledIn(string temp)
        {
            bool result = false;

            if (temp.Length > 0)
            {
                result = true;
            }
            return result;
        } // end of filled in validation----------------------------------------------------------------------------------

        public static bool ValidEmail(string temp)
        {
            bool blresult = true;

            int location = temp.IndexOf("@");
            int location2 = temp.IndexOf("@", location + 1);

            int period = temp.LastIndexOf(".");

            if (temp.Length < 8)
            {
                blresult = false;
            }
            else if (location < 2)
            {
                blresult = false;
            }
            else if (period + 2 > (temp.Length))
            {
                blresult = false;
            }

            return blresult;

        } // end of valid email-----------------------------------------------------------------------------

        public static bool FutureDate(DateTime temp)
        {
            bool result;

            if (temp <= DateTime.Now)
            {
                result = false;
            }
            else result = true;

            return result;
        } // end of furture daten validation-------------------------------------------------------------------

        public static bool MinAmount(int temp, int min)
        {
            bool result;

            if (temp >= min)
            {
                result = true;
            }
            else result = false;

            return result;
        } // end of min amount -int ----------------------------------------------------------------------------------

        public static bool MinAmount1(double temp, double min)
        {
            bool result;

            if (temp >= min)
            {
                result = true;
            }
            else result = false;

            return result;
        } // end of min amount -double -------------------------------------------------------------------------------

        public static bool InvalidChar(string temp)
        {
            bool result = false;

            string[] strInvChhar = { "@", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "!", "#", "$", "%", "^", "&", "*", "(", ")" };

            foreach (string IC in strInvChhar)

                if (temp.Contains(IC))
                {
                    result = true;
                }

            return result;
        }


    }
}
