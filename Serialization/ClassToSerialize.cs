using System;
using System.Collections.Generic;
using System.Text;

namespace Serialization
{
    [Serializable]
    class ClassToSerialize
    {
        private int age;
        private string name;
        static string companyname;
        [NonSerialized]
        private string accountNumber;
        SupportClass supp = new SupportClass();

        public ClassToSerialize()
        {
            supp.SupportClassString = "In support class";
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public static string CompanyName
        {
            get
            {
                return companyname;
            }
            set
            {
                companyname = value;
            }
        }

        public string AccountNumber
        {
            get
            {
                return accountNumber;
            }
            set
            {
                accountNumber = value;
            }
        }

        public string GetSupportClassString()
        {
            return supp.SupportClassString;
        }
    }
}
