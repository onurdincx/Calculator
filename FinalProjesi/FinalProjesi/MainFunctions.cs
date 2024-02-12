using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq; //to list icin
using System.Windows;
using System.Windows.Forms;

namespace FinalProjesi
{
    public static class MainFunctions
    {


        public static Tuple<bool, string> tryToRegister(Form1 Form1Instance)
        {
            var vrResult = helper_methods.checkIfUserNameValid(Form1Instance.textBox6.Text);


            if (vrResult.blResult == false)
            {
                return new Tuple<bool, string>(vrResult.blResult, vrResult.srResultMessage);
            }

            vrResult = helper_methods.checkIfPasswordIsValid(Form1Instance.textBox1.ToString()); //passwordbox olmadigi icin .password methodunu kullanmadim

            if (vrResult.blResult == false)
            {
                return new Tuple<bool, string>(vrResult.blResult, vrResult.srResultMessage);
            }


            if (vrResult.blResult == true)
            {
                File.AppendAllText(helper_methods.srUsersFileName, generateUserInfoFormat(Form1Instance.textBox6.Text,
                    Form1Instance.textBox1.ToString()));
            }


            return new Tuple<bool, string>(vrResult.blResult, vrResult.srResultMessage);
        }

        private static string generateUserInfoFormat(string srUsername, string srPassword)
        {
            return srUsername + helper_methods.crUserInfoSeperatorCharacter +
                srPassword.ComputeSha256Hash() + helper_methods.crUserInfoSeperatorCharacter
                 + Environment.NewLine;
        }


        //login
        public static void tryLogin(Form1 Form1Instance)
        {
            //kayit yeriyle ayni formati kullandim
            string srUserEnteredUserName = Form1Instance.textBox7.Text;
            string srUserEnteredPassword = Form1Instance.textBox2.ToString().ComputeSha256Hash();

            foreach (var vrPerLine in File.ReadLines(helper_methods.srUsersFileName))
            {
                List<string> lstLineDetails = vrPerLine.Split(helper_methods.crUserInfoSeperatorCharacter).ToList();
                if (lstLineDetails[0] == srUserEnteredUserName && srUserEnteredPassword == lstLineDetails[1])
                {
                    helper_methods.doLogin(srUserEnteredUserName);
                    return;
                }


                Form1Instance.displayMessage("Login Error! The username and the password you have entered doesn't match any records in the system.");
            }
           

        }

    }
}
    
