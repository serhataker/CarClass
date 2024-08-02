using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClass
{
    internal class Car
    {
        //We define the car's field
        private string _name;
        private int _model;
        private string _color;
        private int _doorNumber;

        public Car(string name,int model,string color)// we send to 3 parametres for the constructor
        {
                

            _name = name;
            _model = model;
            _color = color;
            _doorNumber = Dournumber(_doorNumber);// we assign the door number if the user input any value
          ;
        }

        // we define the properties for the car object 
        public string Name { get { return _name; } set { _name = value; } }
        public int Model { get { return _model; } set { _model = value; } }
        public string Color { get { return _color; } set { _color = value; } }

        public int DoorNumber { get { return _doorNumber; } } // we only define get method because we define method calculate the dour number for the car


        //Car door set method
          public int Dournumber (int _doorNumber) {

            if (!(_doorNumber == 2 ||_doorNumber==4))
            {

                return -1;

               
            }
            else { return _doorNumber; }
        
        }


    }
    }
