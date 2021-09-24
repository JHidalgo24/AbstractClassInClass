using System;

namespace AbstractClassInClass
{
    public abstract class Vehicle{
        public string Make {get;set;}
        public string Model {get;set;}
        public abstract void Drive();

        //create new abstract method
        public abstract void GasType();
        
        //create new virtual method
        public virtual void TireCount(){
            System.Console.WriteLine("The car has 4 tires");
        }

        public virtual void Start(){
            System.Console.WriteLine("The vehicle has started!");
        }

        public void Stop()
        {
            Console.WriteLine("The vehicle has stopped");
        }




    }    
}