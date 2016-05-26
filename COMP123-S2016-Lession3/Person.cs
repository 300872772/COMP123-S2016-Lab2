using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2016_Lession3
{


    /**
     * this class defines a generic Person
     * 
     * @class Person
     * @field _name {string}
     * @field _age {int}
     * 
     */

    public class Person
    {
        //PRIVATE INSTANCE VARIBLES+++++++++++++++++++++++++++++++++++++++++++++++++++
        private string _name;
        private int _age;

        //PUBLIC PROPERTIES+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
         *this is a property for our _name field
         * 
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

                this._name=value;
            }
        }

        /**
         *This is the default empty constructor for the Person class
         * 
         * @constructor Person 
         * 
         */

        public Person ()
        {
            this._name = "unknown name!";

        }

        /**
        *This is the constructor that takes a parameter and passes it to the _name 
        * pricate instance variable
        * 
        * @constructor Person 
        * @param {string} name
        * 
        */

        public Person(string name)
        {
            this._name = name;

        }

    }


}
