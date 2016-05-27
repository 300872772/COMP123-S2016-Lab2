using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2016_Lession3
{

    //INSTANCE VARIABLE ++++++++++++++++++++++++++++++++++++++++++++++++++++++
    /**
     * this class defines a generic Person
     * 
     * @class Person
     * @field {string}_name 
     * @field {int}_age 
     * 
     */

    public class Person
    {
        //PRIVATE INSTANCE VARIBLES+++++++++++++++++++++++++++++++++++++++++++++++++++
        private string _name;
        private int _age;

        //PUBLIC PROPERTIES+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
         * <summary>
         *this is a property for our _name field
         * </summary>
         * @property {string} Name 
         */
        public string Name
        {
            get
            {
                return this._name;
            }


            set
            {
                Console.WriteLine("_name value set");
                this._name = value;
            }
        }

        /**
        * <summary>
        *this is a property for our _age field
         * </summary>
         * @property {int} Age 
        */
        public int Age
        {

            get
            {
                return this._age;
            }
            set
            {
                this._age = value;
            }
        }

        //CONSTRUCTOR++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
         * <summary>
         *This is the default empty constructor for the Person class
         * </summary>
         * @constructor Person 
         * 
         */

        public Person()
        {
            //initialise public property
            this.Name = "unknown name!";
            // this._name = "unknown name!";
            //this._age = 0;

            this.Age = 0;
        }

        /**
         * <summary>
        *This is the constructor that takes a parameter and passes it to the _name 
        * pricate instance variable
        * </summary>
        * @constructor Person 
        * @param {string} name
        * 
        */

        public Person(string name)
        {
            //this._name = name;
            this.Name = name;
            // this._saysHello();
            this.Age = 0;
        }
        /**
         * <summary>
        *This is the constructor that takes a parameter and passes it to the _age 
        * pricate instance variable
        *</summary> 
        * @constructor Person 
        * @param {int} age
        * 
        */
       /* public Person(int age)
        {
            this._age = age;

        }*/

        public Person(int age)
        {
            this.Name = "unknown name!";
            this.Age = age;
        }
        /**
         * <summary>
        *This is the constructor that takes a parameter and passes it to the _age and _name
        * pricate instance variable
        *</summary> 
        * @constructor Person 
        * @param {int} age
        * @param {string} name
        * 
        */

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        //PUBLIC METHOD++++++++++++++++++++++++++++++++++++++++++++

        /**
         * <summary>
        *This is the method outputs the _name value with "say hello" to the console 
        * </summary>
        * 
        * @Method _sayHello 
        * @returns void
        * 
        */


        /*  private void _saysHello()
          {

              Console.WriteLine(this._name + " says hello");
          }*/



        /**
         * <summary>
        *This is the method that takes a parameter and passes it to the property of _name field 
        * </summary>
        * 
        * @Method SaysHello 
        * @param {string} name
        * 
        */


      /*  public string SaysHello(string name)
        {
            Person person = new Person(name);

            return person.Name + " is ";
        }*/

        /**
 * <summary>
*This is the method that takes a parameter and passes it to the property of _name field 
* </summary>
* 
* @Method SaysHello 
* @param {string} name
* 
*/


        public void SaysHello()
        {
            Console.WriteLine(this.Name + "says hello!");
        }

        /**
         * <summary>
       *This is the method that takes a parameter and passes it to the _age 
       * private instance variable
       * </summary>
       * 
       * @Method ShowAge 
       * @param {int} age
       * 
       */


        /*public string ShowAge(int age)
        {
            Person person = new Person(age);

            return person._age + " years old.";
        }*/


        /**
         * <summary>
       *This method outputs the _name and _age values in the following format: _name + " is " + " years old".
       * private instance variable
       * </summary>
       * 
       * @Method ShowAge 
       * @returns {void}
       * 
       */

        public void ShowAge()
        {
            Console.WriteLine(this.Name + " is " + this.Age);
        }

    }


}
