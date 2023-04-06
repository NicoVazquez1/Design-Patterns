// See https://aka.ms/new-console-template for more information
using Decorator___Robots;


Console.WriteLine("Hello, World!");

int turnN = 1;

IRobot robot = new BaseRobot();
IRobot robot2 = CreateRobotFromConfigFile();

IRobot CreateRobotFromConfigFile()
{
    IRobot robot = new BaseRobot();
    robot.Attack = ConfigurationManager.Instance.GetRobotAttack();
    robot.Health = ConfigurationManager.Instance.GetRobotHealth();
    robot.Price = ConfigurationManager.Instance.GetRobotPrice();
    return robot;

}

IRobot AddEquipment(IRobot robot)
{
    Console.WriteLine("\n Elija equipamiento para su robot \n 1. Rocket launcher \n 2. Protector field \n 3. Default \n");
    ConsoleKeyInfo selection = Console.ReadKey();
    switch (selection.KeyChar)
    {
        case '1':
            Console.WriteLine("\nEquipamiento Rocket launcher seleccionado");
            return new RocketLauncherDecorator(robot);
        case '2':
            Console.WriteLine("\nEquipamiento Protector field seleccionado");
            return new ProtectorFieldDecorator(robot);
        default:
            Console.WriteLine("Selección inválida");
            return robot;
    }
}

void DisplayCombatStrategies(IRobot robot)
{
    Console.WriteLine("\n Elija estrategia de combate \n 1. agresivo \n 2. defensivo \n");
    ConsoleKeyInfo selection = Console.ReadKey();

    switch (selection.KeyChar)
    {
        case '1':
            robot.Strategy = new AgresiveRobotStrategy(robot);
            break;
        case '2':
            robot.Strategy = new DefensiveRobotStrategy(robot);
            break;
        case '3':
            Console.WriteLine("Saliste corriendo");
            robot.RunAway();
            break;
        default:
            Console.WriteLine("Selección inválida");
            break;
    }
}

void DisplayCombatInfo()
{
    turnN++;
    Console.WriteLine($"\n turno {turnN}  \n");
    Console.WriteLine($"Robot I | Vida: {robot.Health} | Defensa: {robot.Defence} | Ataque: {robot.Attack} \n" );
    Console.WriteLine($"Robot II | Vida: {robot2.Health} | Defensa: {robot2.Defence} | Ataque: {robot2.Attack} \n");
}

void ComputeTurn()
{
    DisplayCombatStrategies(robot);
    DisplayCombatStrategies(robot2);

    while (robot.Health > 0 & robot2.Health > 0 & robot.HasRunAway == false)
    {
        robot.Combat(robot2);
        robot2.Combat(robot);
        DisplayCombatInfo();
        Console.Beep();
        Console.ReadKey();
    }
}

DisplayCombatInfo();
robot = AddEquipment(robot);
ComputeTurn();



