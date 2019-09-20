using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        
        static void Main(string[] args)
        {
      Employee E = new Employee();

            try
            {
                Console.WriteLine("Employee Name: " + E._empName);
                Console.WriteLine("Employee ID: " + E._empID);
            }
            catch (NullReferenceException N)
            {
                Console.WriteLine("Error : " + N);
            }
            ////byte numOne = 200;
            //byte numTwo = 5;
            //byte resullt = 0;
            //try
            //{
            //    resullt = checked ( (byte)(numOne * numTwo) );
            //    Console.WriteLine("Result={0}", resullt);

            //}
            //catch (OverflowException of)
            //{
            //    Console.WriteLine("Message: {0}", of.Message);
            //    Console.WriteLine("Source: {0}", of.Source);
            //    Console.WriteLine("TargetSite: {0}", of.TargetSite);
            //    Console.WriteLine("StackTrace: {0}",of.StackTrace);

            //}
            //catch (Exception E) {
            //    Console.WriteLine("Error: {0}",E);
            //}
            //try
            //{
            //    float numOne = 3.14f;
            //    float obj = numOne;
            //    int result = (int)obj;
            //    Console.WriteLine("Value of numOne = {0}",result);

            //}
            //catch(InvalidCastException ic)
            //{
            //    Console.WriteLine("Message : {0}",ic.Message);
            //    Console.WriteLine("Error: {0}",ic);
            //}
            //catch(Exception E)
            //{
            //    Console.WriteLine("Error : {0}",E);
            //}
            Console.ReadKey();
        }
    }
    class Employee
    {
        public string _empName;
        public int _empID;
        public Employee()
        {
            _empName = "RB Is Boerd";
            _empID = 92;
        }
        
    }
}
