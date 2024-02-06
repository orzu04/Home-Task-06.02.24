

public abstract  class Animal
{
 string _name;
  public void SetName (string name)
  {
     _name = name;
  }
  public virtual string GetName ()
  {
    return _name;
  }

public   abstract  void Eat();


}
