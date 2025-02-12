using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RsaIdValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsValidRsaId("9802156463085")); // Should return True
            Console.WriteLine(IsValidRsaId("9605156463085")); // Should return False
        }
        // Main method to validate the RSA ID number
        public static bool IsValidRsaId(string idNumber)
        {
            // Check if the ID number is null or empty
            if (string.IsNullOrEmpty(idNumber))
                return false;

            // Perform all validation checks
            if (!IsLengthValid(idNumber))
                return false;

            if (!IsAllDigits(idNumber))
                return false;

            if (!IsDateOfBirthValid(idNumber))
                return false;

            if (!IsGenderValid(idNumber))
                return false;

            if (!IsCitizenshipValid(idNumber))
                return false;

            if (!IsDigitAValid(idNumber))
                return false;

            if (!IsLuhnChecksumValid(idNumber))
                return false;

            // All checks passed
            return true;
        }

        // Checks if the ID number is exactly 13 characters long
        private static bool IsLengthValid(string idNumber)
        {
            return idNumber.Length == 13;
        }

        // Checks if all characters in the ID number are digits
        private static bool IsAllDigits(string idNumber)
        {
            foreach (char c in idNumber)
            {
                if (!char.IsDigit(c))
                    return false;
            }
            return true;
        }

        // Validates the date of birth extracted from the ID number
        private static bool IsDateOfBirthValid(string idNumber)
        {
            // Extract the first six digits as the date of birth part (YYMMDD)
            string dateOfBirthPart = idNumber.Substring(0, 6);

            // Try to parse the date of birth
            if (DateTime.TryParseExact(dateOfBirthPart, "yyMMdd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dateOfBirth))
            {
                // Adjust for century if the date is in the future (assume dates in the future are from the previous century)
                if (dateOfBirth > DateTime.Now)
                    dateOfBirth = dateOfBirth.AddYears(-100);

                // Check if the date is not in the future
                return dateOfBirth <= DateTime.Now;
            }
            // Invalid date format
            return false;
        }

        // Validates the gender digits in the ID number
        private static bool IsGenderValid(string idNumber)
        {
            // Extract digits 7 to 10, which represent gender sequence numbers
            string genderDigits = idNumber.Substring(6, 4);
            // Check if these digits are numeric
            return int.TryParse(genderDigits, out _);
        }

        // Validates the citizenship character in the ID number
        private static bool IsCitizenshipValid(string idNumber)
        {
            // The 11th character indicates citizenship ('0' for SA citizen, '1' for permanent resident)
            char citizenshipChar = idNumber[10];
            return citizenshipChar == '0' || citizenshipChar == '1';
        }

        // Validates the 'A' digit in the ID number
        private static bool IsDigitAValid(string idNumber)
        {
            // The 12th character must be '8' or '9' according to the specific ID format
            char digitA = idNumber[11];
            return digitA == '8' || digitA == '9';
        }

        // Validates the ID number using the Luhn algorithm
        private static bool IsLuhnChecksumValid(string idNumber)
        {
            int sum = 0;
            bool alternate = false;

            // Iterate over the digits from right to left
            for (int i = idNumber.Length - 1; i >= 0; i--)
            {
                // Parse the current digit
                int digit = int.Parse(idNumber[i].ToString());

                if (alternate)
                {
                    // Double every second digit
                    digit *= 2;

                    // If the result is greater than 9, subtract 9 (or add the digits together)
                    if (digit > 9)
                        digit -= 9;
                }

                // Add the digit to the total sum
                sum += digit;

                // Alternate flag for every other digit
                alternate = !alternate;
            }

            // The ID number is valid if the total sum is a multiple of 10
            return (sum % 10) == 0;
        }
    }
}
