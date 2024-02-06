namespace task4;

public class Car : IVehicle
{
    double gas;
    public void Drive(double gasoline)
    {
       if(gasoline > 0){
        System.Console.WriteLine("Driving");
       }else{
        System.Console.WriteLine("gasoline not enough for driving");
       }
    }

    public bool Refuel(double gasoline)
    {
        gas += gasoline;
        return true;
    }
}
