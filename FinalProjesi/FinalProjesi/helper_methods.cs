using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Globalization;
using System.Net.Mail;
using System.IO;
using System.Security.Cryptography; //sifreyi hashlemek icin

namespace FinalProjesi
{
    public static class helper_methods
    {

        public static Form1 runningWindow;


        public static string srUserLoggedInName = "";
        public static bool blUserLoggedIn = false;


        public static char crUserInfoSeperatorCharacter = ';';

        public static string srUsersFileName = "users.txt";

        private static List<char> lstSpecialCharacterList = new List<char> {
            '@', '#', '$', '%', '&', '*', '!', ';', '?' };

        private static string srUsernameAllowedCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZŞĞÖÇÜİ _";

        private static int irMinLenghtUserName = 3;//allow only 3 characters lenght username
        private static int irMaxLenghtUserName = 20;

        private static int irMinPasswordLenght = 8;

        private static List<char> lstAllowedCharacters = new List<char>();

        private static List<char> lstAllowedCharactersDefaultBehaviour = new List<char>();

        private static List<char> lstInvariantCultureDifference = new List<char>();

        static helper_methods()
        {
            foreach (var vrPerChar in srUsernameAllowedCharacters.ToCharArray())
            {
                lstAllowedCharacters.Add(vrPerChar);
            }

            

            foreach (var vrPerChar in srUsernameAllowedCharacters.ToLower(new System.Globalization.CultureInfo(
                "tr-TR")))//karakter dizisi
            {
                lstAllowedCharacters.Add(vrPerChar);
            }

            foreach (var vrPerChar in srUsernameAllowedCharacters.ToUpper(new System.Globalization.CultureInfo(
         "tr-TR")))//karakter dizisine donusturur
            {
                lstAllowedCharacters.Add(vrPerChar);
            }

            lstAllowedCharacters = lstAllowedCharacters.Distinct().ToList();//bu, LinQ uzantı yöntemini kullanarak yinelenen öğeleri listeden kaldıracaktır



            foreach (var vrPerChar in srUsernameAllowedCharacters.ToLower())
            {
                lstAllowedCharactersDefaultBehaviour.Add(vrPerChar);
            }

            //try invariant with en-us culture

            foreach (var vrPerChar in srUsernameAllowedCharacters.ToLowerInvariant())
            {
                lstInvariantCultureDifference.Add(vrPerChar);
            }
        }

        public static string normalizeUserName(this string srUserName)
        {
            
            return srUserName.ToUpper(new CultureInfo("en-US")).RemoveDiacritics().ToLower(new CultureInfo("en-US")).Trim();
        }

        static string RemoveDiacritics(this string text)
        {
            var normalizedString = text.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();

            foreach (var c in normalizedString)
            {
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }

        public class actionResult
        {
            public bool blResult = true;
            public string srResultMessage = "NA";
        }

        public static actionResult checkIfUserNameValid(string srUserName)
        {
            

            actionResult checkResult = new actionResult();

            if (srUserName.Length < irMinLenghtUserName)
            {
                checkResult.blResult = false;
                checkResult.srResultMessage = $"Your username can not be less than {irMinLenghtUserName} characters lenght";
            }

            if (srUserName.Length > irMaxLenghtUserName)
            {
                checkResult.blResult = false;
                checkResult.srResultMessage = $"Your username can not be bigger than {irMaxLenghtUserName} characters lenght";
            }

            foreach (var vrUserNameChar in srUserName)
            {
                if (lstAllowedCharacters.Contains(vrUserNameChar) == false)
                {
                    checkResult.blResult = false;
                    checkResult.srResultMessage = $"Your username can not contain character “{vrUserNameChar}”";
                }
            }

            if (File.Exists(srUsersFileName))
            {
                //username;hashed_password TARAMA

                foreach (var vrPerLine in File.ReadLines(srUsersFileName))
                {

                    List<string> lstSplittedStrings = vrPerLine.Split(crUserInfoSeperatorCharacter).ToList();//tolist linq uzantısıdır ve split dize uzantısıdır.

                    string srRegisteredUserName = lstSplittedStrings[0];
                    

                    var vrFileSavedUserName = srRegisteredUserName.normalizeUserName();
                    var vrNormalizedSelectedUserName = srUserName.normalizeUserName();

                    if (vrFileSavedUserName == vrNormalizedSelectedUserName)
                    {
                        checkResult.blResult = false;
                        checkResult.srResultMessage = $"Your selected username is not available. Please pick another username";
                        break;
                    }

                  
                }

            }

            return checkResult;
        }


        public static actionResult checkIfPasswordIsValid(string srPw1)
        {
            actionResult checkResult = new actionResult();

            /*if (srPw1 != srPwRepeat)
            {
                checkResult.blResult = false;
                checkResult.srResultMessage = $"Your entered passwords are not matching. Please re-enter your password.";
            }
            */
            if (srPw1.Length < irMinPasswordLenght && checkResult.blResult == true)
            {
                checkResult.blResult = false;
                checkResult.srResultMessage = $"Your password has to be minimum 8 characters";
            }

            bool blContainsDigit = false, blContainsLetter = false, blContainsUpperCase = false, blContainsLowerCase = false, blContainsSpecialCharacter = false;

            foreach (char vrPerChar in srPw1.ToCharArray())
            {
                if (char.IsDigit(vrPerChar))
                    blContainsDigit = true;
                if (char.IsLetter(vrPerChar))
                    blContainsLetter = true;
                if (char.IsUpper(vrPerChar))
                    blContainsUpperCase = true;
                if (char.IsLower(vrPerChar))
                    blContainsLowerCase = true;
                if (lstSpecialCharacterList.Contains(vrPerChar))
                    blContainsSpecialCharacter = true;
            }

            if (!blContainsDigit && checkResult.blResult == true)
            {
                checkResult.blResult = false;
                checkResult.srResultMessage = $"Your password has to contain a numeric character";
            }

            if (!blContainsLetter && checkResult.blResult == true)
            {
                checkResult.blResult = false;
                checkResult.srResultMessage = $"Your password has to contain a letter";
            }

            if (!blContainsUpperCase && checkResult.blResult == true)
            {
                checkResult.blResult = false;
                checkResult.srResultMessage = $"Your password has to contain an upper case character";
            }

            if (!blContainsLowerCase && checkResult.blResult == true)
            {
                checkResult.blResult = false;
                checkResult.srResultMessage = $"Your password has to contain a lower case character";
            }

            

            return checkResult;
        }

       
        public static string ComputeSha256Hash(this string rawData) //SIFRELERI HASH'LEME. HACKERLERDEN SAKLAMAK
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public static void doLogin(string _srUserLoggedInName)
        {
            srUserLoggedInName = _srUserLoggedInName;
            blUserLoggedIn = true;
            runningWindow.tabControl1.Enabled = true;
            runningWindow.Register.Enabled = false;
            runningWindow.Login.Enabled = false;
            runningWindow.Calculator.Enabled = true;
            runningWindow.lblLoggedInUserName.Text = "Logged User: " + _srUserLoggedInName;
            runningWindow.displayMessage("You have successfully logged-in");


        }

        public static void doLogout()
        {
            srUserLoggedInName = "successfully logged out!";
            blUserLoggedIn = false;
            runningWindow.tabControl1.Enabled = true;
            runningWindow.Register.Enabled = true;
            runningWindow.Login.Enabled = true;
            runningWindow.Calculator.Enabled = false;
            runningWindow.lblLoggedInUserName.Text = srUserLoggedInName;



        }
        }

    }    