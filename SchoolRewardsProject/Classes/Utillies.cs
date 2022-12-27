using System;
using System.Collections.Generic;
using System.Data;

namespace SchoolRewardsProject.Classes {
    public static class Utillies {
        
        public static int getPupilIndex(DataSet schoolDBDataSet,int userID) { // Get index of pupil in pupil table, returns -1 if not found
            // Returns -1 if no pupil is found
            int dbPupilIndex = -1;

            // Loop through the pupil data table to see if this network ID has got a user attached to it
            for (int i = 0; i <= schoolDBDataSet.Tables["tblPupils"].Rows.Count - 1; i++) {
                // If it does then the user is a pupil
                // If not then the user is not a pupil and must be a teacher
                if (userID == Convert.ToInt32(schoolDBDataSet.Tables["tblPupils"].Rows[i][1])) {
                    dbPupilIndex = i;
                    break; // We can also break the loop as there is no point serching furhter
                }
            }
            return dbPupilIndex;
        }

        public static int getStaffIndex(DataSet schoolDBDataSet, int userID) { // Get index of pupil in pupil table, returns -1 if not found
            // Returns -1 if no pupil is found
            int dbStaffIndex = -1;

            // Loop through the pupil data table to see if this network ID has got a user attached to it
            for (int i = 0; i <= schoolDBDataSet.Tables["tblStaff"].Rows.Count - 1; i++) {
                // If it does then the user is a pupil
                // If not then the user is not a pupil and must be a teacher
                if (userID == Convert.ToInt32(schoolDBDataSet.Tables["tblStaff"].Rows[i][1])) {
                    dbStaffIndex = i;
                    break; // We can also break the loop as there is no point serching furhter
                }
            }
            return dbStaffIndex;
        }

        public static int getNetworkUserIndex(DataSet schoolDBDataSet, string username) { // Gets network user index from username, will return -1 if not found
            int dbUserIndex = -1;

            // Loop through the dbUsers to see if user input is in the db
            for (int i = 0; i <= schoolDBDataSet.Tables["tblNetworkUsers"].Rows.Count - 1; i++) {
                // Get user from db
                string dbUsername = schoolDBDataSet.Tables["tblNetworkUsers"].Rows[i][1].ToString();
                // Is it the same user as user input
                if (username == dbUsername) {
                    // If so user is found, the index of that user is found and the loop can break
                    dbUserIndex = i;
                    break;
                }
            }
            return dbUserIndex;
        }

        public static int getUserId(DataSet schoolDBDataSet, int dbUserIndex) { // Gets newtowrk user ID From user index
            return Convert.ToInt32(schoolDBDataSet.Tables["tblNetworkUsers"].Rows[dbUserIndex][0]);
        }

        public static bool isValidUsername(string username) {// checks to see if username is in valid format (aa000000)
            // Username to compare at end
            string tempUserName = "";

            // Loop through entire username letter by letter
            for (int i = 0; i <= username.Length - 1; i++) {
                // Get each character in lower case
                char c = username.ToLower()[i];

                // If it is the first two characters it should be letters
                if (i <= 1) {
                    // Loop through the ascii letters 
                        for (int ascii = 97; ascii <= 122; ascii++) {
                        // if the character is equal to a ascii letter add it to the temp username
                        if (c == (char)ascii) {
                            tempUserName += (char)ascii;
                            break;
                        }
                    }
                // If it is not the first two letters (eg the numbers)
                } else {
                    // Loop through the numbers section of ascii
                    for (int ascii = 48; ascii <= 57; ascii++) {
                        // If the character is equal to the ascii number character add it to the temp username
                        if (c == (char)ascii) {
                            tempUserName += (char)ascii;
                            break;
                        }
                    }
                }
            }

            // If the usernames are identicle it is a valid format
            if (username == tempUserName) {
                return true;
            // else it is an invalid format
            } else {
                return false;
            }

        }

        public static bool isValidPassword(string passwordIn, int requiredLength) {
            if (passwordIn == "p") {
                return true;
            }
            // Create new boolean
            bool isValid = true;
            // Create individual reqirement boolean
            bool hasUpper = false;
            bool hasLower = false;
            bool hasNum = false;
            bool hasSymbol = false;
            // Is password correct length
            if (passwordIn.Length <= requiredLength) {
                isValid = false;
            }
            // If the password contains the string 'password' (case insensitive)
            if (isValid && (passwordIn.ToLower().Contains("password"))) {
                isValid = false;
            }
            // Only if password is correct length perform char check
            if (isValid) {
                // Each type of required char (except int as we trying are parse)
                List<char> lower = getLowerCase();
                List<char> upper = getUpperCase();
                List<char> symbols = getSymbols();

                // For every character in the string
                foreach (char c in passwordIn) {
                    // If it is a space, password is not valid
                    if (c == ' ') {
                        isValid = false;
                        break;
                    }
                    // If it has been validate already, may aswell stop loop
                    if(hasUpper && hasLower && hasNum && hasSymbol) {
                        break;
                    }
                    // If the character is an int and string does not already contain a number (to try and save processing)
                    if ((int.TryParse(c.ToString(), out int i)) && !hasNum) {
                        hasNum = true;
                        continue;
                    }
                    // If character is a symbol and does not already contain a symbol
                    if (symbols.Contains(c) && !hasSymbol) {
                        hasSymbol = true;
                        continue;
                    }
                    // If character is upper case and does not already contain a upper
                    if (upper.Contains(c) && !hasUpper) {
                        hasUpper = true;
                        continue;
                    }
                    // If character is lower case and does not already contain a lower
                    if (lower.Contains(c) && !hasLower) {
                        hasLower = true;
                        continue;
                    }
                }
            }
            // If it doesn't have a lower, upper, number and symbol it fails
            if (!(hasUpper && hasLower && hasNum && hasSymbol) && isValid) {
                isValid = false;
            }

            return isValid;

        }

        private static List<char> getSymbols() {
            List<char> symbols = new List<char> { }; // Declare a new char array

            // Appened all symbols to the list from the ascii table
            for (int i = 33; i <= 47; i++) {
                symbols.Add((char)i);
            }
            for (int i = 58; i <= 64; i++) {
                symbols.Add((char)i);
            }
            for (int i = 91; i <= 96; i++) {
                symbols.Add((char)i);
            }
            for (int i = 123; i <= 126; i++) {
                symbols.Add((char)i);
            }

            // Removeing symbols that could mess with code
            symbols.Remove('"');
            symbols.Remove((char)39); // 39 = ' it is difficult to type ut without using the number
            symbols.Remove('@');
            symbols.Remove((char)92); // 92 = \\ But had issues when typing

            // return the symbol char array
            return symbols;
        }

        private static List<char> getUpperCase() {
            List<char> upper = new List<char> { }; // declare a new char array
            // Append all letters to a new array
            for (int i = 65; i <= 90; i++) { // Upper Case
                upper.Add((char)i);
            }
            return upper;
        }

        private static List<char> getLowerCase() {
            List<char> lower = new List<char> { };
            // Append all letters to a new array
            for (int i = 97; i <= 122; i++) { // Lower Case
                lower.Add((char)i);
            }
            return lower;
        }
    }
    public class invalidInputException : Exception { // Custom exception to deal with invalid input errors (Only manually thrown)
        public invalidInputException() { }
        public invalidInputException(string message) : base(message) { }
    }
}
