using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace COMP123_S2016_Lab2
{

    /**
     * this class is the driver class for the Program
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
            //create a new instance of Person class
             Person mamun;
            mamun = new Person("Mamun");
            mamun.SaysHello();
            Console.WriteLine();

            Person jhon;
            jhon = new Person("Jhon",30);
            jhon.ShowAge();
            Console.WriteLine();

            Person sonia;
            sonia = new Person("Sonia", 22,5.8);
            sonia.ShowHeight();
            Console.WriteLine();

            Person sahil;
            sahil = new Person("Sahil",30,5.5,"male");
            sahil.ShowGender();
            Console.WriteLine();

        }



    }




}
