public abstract class Transport
{

    public abstract int Speed { get; set; }
    public abstract int LoadCapacity { get; set; }
    public abstract int Range { get; set; }

    public Transport(int speed, int loadCapacity, int range){
        Speed = speed;
        LoadCapacity = loadCapacity;
        Range = range;
    }

    public abstract void DisplayInfo();
}

public class Car : Transport
{
    public override int Speed { get; set; }
    public override int LoadCapacity { get; set; }
    public override int Range{ get; set; }

    public Car(int speed, int loadCapacity, int range) : base(speed, loadCapacity, range) { }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Машина с грузоподъемностью в {LoadCapacity} может проехать {Range}");
    }
}

public class Airplane : Transport
{
    public override int Speed { get; set; }
    public override int LoadCapacity { get; set; }
    public override int Range { get; set; }

    public Airplane(int speed, int loadCapacity, int range) : base(speed, loadCapacity, range) { }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Самолет с грузоподъемностью в {LoadCapacity} может пролететь {Range}");
    }
}

public class Ship : Transport
{
    public override int Speed { get; set; }
    public override int LoadCapacity { get; set; }
    public override int Range { get; set; }

    public Ship(int speed, int loadCapacity, int range) : base(speed, loadCapacity, range) { }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Корабль с грузоподъемностью в {LoadCapacity} может пройти {Range}");
    }
}

class Program
{
    static void Main()
    {
        Car car = new Car(10, 20, 30);
        Airplane airplane = new Airplane(12, 23, 34);
        Ship ship = new Ship(90, 80, 70);

        car.DisplayInfo();
        airplane.DisplayInfo();
        ship.DisplayInfo();
    }
}