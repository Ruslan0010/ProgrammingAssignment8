using System;
using System.IO;

namespace ProgrammingAssignment1
{
    /// <summary>
    /// A class holding personal data for a person
    /// </summary>
    public class PersonalData
    {
        #region Fields

        private string firstName;
        private string middleName;
        private string lastName;
        private string streetAddress;
        private string city;
        private string state;
        private string postalCode;
        private string country;
        private string phoneNumber;

        #endregion

        #region Properties

        /// <summary>
        /// Gets the person's first name
        /// </summary>
        public string FirstName
        {
            get { return firstName; }
        }

        /// <summary>
        /// Gets the person's middle name
        /// </summary>
        public string MiddleName
        {
            get { return middleName; }
        }

        /// <summary>
        /// Gets the person's last name
        /// </summary>
        public string LastName
        {
            get { return lastName; }
        }

        /// <summary>
        /// Gets the person's street address
        /// </summary>
        public string StreetAddress
        {
            get { return streetAddress; }
        }

        /// <summary>
        /// Gets the person's city or town
        /// </summary>
        public string City
        {
            get { return city; }
        }

        /// <summary>
        /// Gets the person's state or province
        /// </summary>
        public string State
        {
            get { return state; }
        }

        /// <summary>
        /// Gets the person's postal code
        /// </summary>
        public string PostalCode
        {
            get { return postalCode; }
        }

        /// <summary>
        /// Gets the person's country
        /// </summary>
        public string Country
        {
            get { return country; }
        }

        /// <summary>
        /// Gets the person's phone number (digits only, no 
        /// parentheses, spaces, or dashes)
        /// </summary>
        public string PhoneNumber
        {
            get { return phoneNumber; }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor
        /// Reads personal data from a file. If the file
        /// read fails, the object contains an empty string for all
        /// the personal data
        /// </summary>
        /// <param name="fileName">name of file holding personal data</param>
        public PersonalData(string fileName)
        {
            try
            {
                string[] data = File.ReadAllText(fileName).Split(',');
                if (data.Length != 9)
                {
                    firstName = middleName = lastName = streetAddress = city = state = postalCode = country = phoneNumber = "";
                }
                else
                {
                    firstName = data[0];
                    middleName = data[1];
                    lastName = data[2];
                    streetAddress = data[3];
                    city = data[4];
                    state = data[5];
                    postalCode = data[6];
                    country = data[7];
                    phoneNumber = data[8];
                }
            }
            catch (Exception)
            {
                firstName = middleName = lastName = streetAddress = city = state = postalCode = country = phoneNumber = "";
            }
        }

        #endregion
    }
}
