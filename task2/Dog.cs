

public class Dog :Animal
{


     string _name;

    public Dog (string name)
    {
        _name = name;

    }
    public override string GetName()
    {
        return $"{_name} ";
    }

    public override void Eat (){
        System.Console.WriteLine($"Name Dog:");
        System.Console.WriteLine($"{_name}");
          System.Console.WriteLine($"Woof");
    }

}