namespace AbstractClassInClass{
    public class Dodge : Vehicle
    {
        public override void Drive()
        {
            System.Console.WriteLine("The Dodge is driving!");
        }

        public override void TireCount()
        {
            System.Console.WriteLine("The car has 6 tires");
        }

        public override void GasType()
        {
            System.Console.WriteLine("The car runs on regular gasoline (Not diesel)");
        }
    }
}