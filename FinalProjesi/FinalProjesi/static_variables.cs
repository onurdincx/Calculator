using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace FinalProjesi
{

    public static class static_variables
    {

        private static int MinLenghtUserName = 3; // EN AZ 3

        public class actionResult
        {
            public bool blResult = true;
            public string srResultMessage = "NA";
        }
        //register kismi
        private static string srUsersFileName = "users.txt";

        public static actionResult CheckIfUserNameValid(string srUserName)
        {
            actionResult checkResult = new actionResult();

            if (srUserName.Length < MinLenghtUserName)
            {
                checkResult.blResult = false;
                checkResult.srResultMessage = "Your username can not be less than 3 characters length.";
            }

            if (File.Exists(srUsersFileName))
            {
                //username;hashed_password TARAMA
                foreach (var vrPerLine in File.ReadLines(srUsersFileName))
                {
                    List<string> lstSplittedStrings = vrPerLine.Split(';').ToList(); //tolist linq uzantısıdır ve split dize uzantısıdır.

                    string srRegisteredUserName = lstSplittedStrings[0];



                    var vrFileSavedUserName = srRegisteredUserName.normalizeUserName();
                    var vrNormalizedSelectedUserName = srUserName.normalizeUserName();

                    if (vrFileSavedUserName == vrNormalizedSelectedUserName)
                    {
                        checkResult.blResult = false;
                        checkResult.srResultMessage = $"Your selected username is not avaible. Please pick another username.";
                        break;

                    }

                }
            }

            return checkResult;

        }
    }

}
