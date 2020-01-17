using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Serialization
{
    class SerialTest
    {
        public void SerializeNow()
        {
         
            try
            {
                ClassToSerialize c = new ClassToSerialize
                {
                    Name = "bipin",
                    Age = 26,
                    AccountNumber = "6258730521"
                };
                ClassToSerialize.CompanyName = "xyz";

                //Create an instance of FileStream that will store serialized object
                using (
                    FileStream fs = File.Create("C:\\Users\\Dev Ops\\Documents\\Visual Studio 2019\\Projects\\SerializationAndDeserialization\\Serialization\\temp.txt")
                    )
                {
                    ////Create an instance of BinaryFormatter
                    BinaryFormatter b = new BinaryFormatter();

                    //Call serialize method of the instance passing it stream and object to serialize
                    b.Serialize(fs, c);
                    Console.WriteLine("Serialization successful");
                }
            }

            catch(Exception e)
            {
                Console.WriteLine("Ooops! Something went wrong");
                Console.WriteLine(e.ToString());
            }
        }

        public void DeSerializeNow()
        {
            try
            {

                ClassToSerialize c = new ClassToSerialize();
                FileStream fs = File.OpenRead("temp.dat");
                BinaryFormatter b = new BinaryFormatter();

                //call deserialize method of BinaryFormatter object and cast it back to object of type ClassToSerialize
                c = (ClassToSerialize)b.Deserialize(fs);
                Console.WriteLine("Deserialization successful!");
                Console.WriteLine("Name: " + c.Name);
                Console.WriteLine("Age: " + c.Age);
                Console.WriteLine("Company Name: " + ClassToSerialize.CompanyName);
                Console.WriteLine("AccountNumber: " + c.AccountNumber);
                Console.WriteLine("Company Name: " + c.GetSupportClassString());
                fs.Close();
            }

            catch (Exception e)
            {
                Console.WriteLine("Ooops! Something went wrong");
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
