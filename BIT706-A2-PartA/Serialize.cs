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
    /// <summary>
    /// 
    /// </summary>
    public class Serialize
    {
        private static Controller control = new Controller();
        /// <summary>
        /// downloads all the customer information
        /// </summary>
        public void serializing()
        { 
            //This stream with put all the data into Part-E folder for you
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

        /// <summary>
        /// uploads all the customer information
        /// </summary>
        public void deSerializing()
        {
            control.getAllCustomers().allCustomersList.Clear();
            try
            {
                //This stream with put all the data into Part-E folder for you
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
