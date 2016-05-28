using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2016_Lab2
{

    //INSTANCE VARIABLE ++++++++++++++++++++++++++++++++++++++++++++++++++++++
    /**
     * this class defines a generic Person
     * 
     * @class Person
     * @field {string}_name 
     * @field {int}_age
     * @field {double} _height
     * @field {bool} _gender
     * 
     */

    public class Person
    {
        //PRIVATE INSTANCE VARIBLES+++++++++++++++++++++++++++++++++++++++++++++++++++
        private string _name;
        private int _age;
        private double _height;
        private bool _gender;

        //PUBLIC PROPERTIES+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
         * <summary>
         *this is a property for _name field
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
                
                this._name = value;
            }
        }

        /**
        * <summary>
        *this is a property for _age field
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

        /**
         * <summary>
         *this is a property for _height field
         * </summary>
         * @property {double} Height 
         * 
         */
        public double Height
        {

            get
            {
                return this._height;
            }
            set
            {
                this._height = value;
            }
        }

        /**
         * <summary>
         *this is a property for _gender field
         * </summary>
         * @property {bool} Gender 
         * 
         */
        public bool Gender
        {

            get
            {
                return this._gender;
            }
            set
            {
                this._gender = value;
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
            _initialise();
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
            this._initialise();
            this.Name = name;

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

        public Person(int age)
        {
            this._initialise();
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
            this._initialise();
            this.Name = name;
            this.Age = age;
        }
        /**
        * <summary>
        *This is the constructor that takes a parameter and passes it to the  _name, _age and _height
        * pricate instance variable
        *</summary> 
        * @constructor Person 
        * @param {int} age
        * @param {string} name
        * @param {double} height
        * 
        */

        public Person(string name, int age, double height)
        {
            this._initialise();
            this.Name = name;
            this.Age = age;
            this.Height = height;
        }
        /**
         * <summary>
        *This is the constructor that takes a parameter and passes it to the  _name, _age, _height and _gender
        * pricate instance variable
        *</summary> 
        * @constructor Person 
        * @param {int} age
        * @param {string} name
        * @param {double} height
        * @param {bool} gender
        * 
        */

        public Person(string name, int age, double height, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Height = height;

            if (gender.ToUpper() == "MALE")
            {
                this.Gender = true;
            }
            else
            {
                this.Gender = false;
            }
        }


        //PRIVATE METHOD++++++++++++++++++++++++++++++++++++++++++++

        /**
        * <summary>
        *This is the method initializes the public properties Name and Age
        * </summary>
        * 
        * @Method _initialise 
        * @returns void
        * 
        */
        private void _initialise()
        {
            this.Name = "unknown name!";
            this.Age = 0;
            this.Height = 0;
            this.Gender = true;
        }

        //PUBLIC METHOD++++++++++++++++++++++++++++++++++++++++++++

        /**
        * <summary>
        *This is the method that takes a parameter and passes it to the property of _name field 
        * </summary>
        * 
        * @Method SaysHello 
        * @return {void}
        * 
        */


        public void SaysHello()
        {
            Console.WriteLine(this.Name + " says hello!");
        }


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
            Console.WriteLine(this.Name + " is " + this.Age + " years old!.");
        }


        /**
         * <summary>
       *This method outputs the _name, _age and _height values in the following format: _name + " is " + _age + " years old" +"with height" + _height + " feet".
       * </summary>
       * 
       * @Method ShowHeight 
       * @returns {void}
       * 
       */

        public void ShowHeight()
        {
            Console.WriteLine(this.Name + " is " + this.Age + " years old with height " + this.Height + " feet.");
        }


        /**
         * <summary>
        *This method outputs the _name, _age and _height values in the following format: _name + " is " + _age + " years old" +" and his" or "and her" + height is" 
        * + _height + "feet."
        * </summary>
        * 
        * @Method ShowHeight 
        * @returns {void}
        * 
        */

        public void ShowGender()
        {
            if (this.Gender == true)
            {
                Console.WriteLine(this.Name + " is " + this.Age + " years old and his height is " + this.Height + " feet.");
            }
            else
            {
                Console.WriteLine(this.Name + " is " + this.Age + " years old and her height is " + this.Height + " feet.");
            }
        }



    }


}
