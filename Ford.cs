using System;

namespace AbstractClassInClass
{
    public class Ford: Vehicle
    {
        public string Color {get;set;}
        public override void Drive()
        {
            System.Console.WriteLine("The Ford is Driving!");
        }

        public override void GasType()
        {
            System.Console.WriteLine("The car runs on regular gas (Not Diesel)");
        }

        public override void Start(){
            System.Console.WriteLine("The Ford has started!");
        }
    }
}