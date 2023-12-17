abstract class TechProductFactory
{
    public abstract Screen CreateScreen();
    public abstract Processor CreateProcessor();
    public abstract Camera CreateCamera();
}

class SmartphoneFactory : TechProductFactory
{
    public override Screen CreateScreen() { return new SmartphoneScreen(); }
    public override Processor CreateProcessor() { return new SmartphoneProcessor(); }
    public override Camera CreateCamera() { return new SmartphoneCamera(); }
}

class LaptopFactory : TechProductFactory
{
    public override Screen CreateScreen() { return new LaptopScreen(); }
    public override Processor CreateProcessor() { return new LaptopProcessor(); }
    public override Camera CreateCamera() { return new LaptopCamera(); }
}

abstract class Screen { }
abstract class Processor { }
abstract class Camera { }

class SmartphoneScreen : Screen { }
class SmartphoneProcessor : Processor { }
class SmartphoneCamera : Camera { }

class LaptopScreen : Screen { }
class LaptopProcessor : Processor { }
class LaptopCamera : Camera { }

class Client
{
    private Screen _screen;
    private Processor _processor;
    private Camera _camera;

    public Client(TechProductFactory factory)
    {
        _screen = factory.CreateScreen();
        _processor = factory.CreateProcessor();
        _camera = factory.CreateCamera();
    }

    public void Run()
    {
        Console.WriteLine($"Created {_screen.GetType().Name}");
        Console.WriteLine($"Created {_processor.GetType().Name}");
        Console.WriteLine($"Created {_camera.GetType().Name}");
    }
}