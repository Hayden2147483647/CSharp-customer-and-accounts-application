using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace BIT706_A2_PartA
{
    
    public class Serialize
    {
        private static Controller control = new Controller();
        //downloads all the customer information
        public void serializing()
        { 
            FileStream stream = new FileStream("..\\..\\..\\..\\Part-E\\CustomerData.dat", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                formatter.Serialize(stream, control.getAllCustomers().allCustomersList);
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to Serialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                stream.Close();
            }
        }

        //uploads all the customer information
        public void deSerializing()
        {
            control.getAllCustomers().allCustomersList.Clear();
            try
            {
                FileStream stream = new FileStream("..\\..\\..\\..\\Part-E\\CustomerData.dat", FileMode.Open);

                try
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    control.getAllCustomers().allCustomersList = (List<Customer>)formatter.Deserialize(stream);
                }
                catch (SerializationException e)
                {
                    Console.WriteLine("Failed to Deserialize. Reason: " + e.Message);
                }
                finally
                {
                    stream.Close();
                }
            }
            catch (System.IO.FileNotFoundException e)
            {
                Console.WriteLine("File not found. Reason: " + e.Message);
            }
        }

    }
}
