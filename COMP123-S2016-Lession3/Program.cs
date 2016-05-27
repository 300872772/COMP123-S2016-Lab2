using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace COMP123_S2016_Lession3
{

    /**
     * this class is the driver class for our Program
     * 
     * @class Program
     * 
     */
   public class Program


    {
        /**
         * the main method for our driver class Program
         * 
         * @method Main
         * @param {string []} args
         * 
         */

       public static void Main(string[] args)
        {
            //crat a new instance of Person class
             Person tom;
             tom = new Person("Tom");
            tom.SaysHello();
            Console.WriteLine();

            //set a value in the Name property of the Person class
            //  person.Name = "Tom";

            //get the Name value and print to console

            // Console.WriteLine(person.Name);

            //  Person person = new Person();


            //  Console.WriteLine(person.SaysHello("Tom") + person.ShowAge(50));

            Person mark = new Person(30);
            mark.Name = "Mark";
            mark.ShowAge();

            Console.WriteLine();

            Person marry = new Person("Marry", 23);
            marry.SaysHello();
            marry.ShowAge();

            Person tanya = new Person();
            tanya.Name = "Tanya";
            tanya.Age = 28;
            tanya.SaysHello();
            tanya.ShowAge();

        }



    }




}
