using System.Text;
using ConsoleApp1;

public class Program
{
    public static void Main()
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;
        ElevatorType elevator = new ElevatorType(1995, "Modern", 15.0, 5, 12, false);
        Console.WriteLine(elevator.GetStatus());
        
        Console.WriteLine("Визвати ліфт?\n1.Так.\n2.Ні.");
        int Userchoice = Convert.ToInt16(Console.ReadLine());
        if (Userchoice == 1)
        {
            Console.WriteLine(elevator.ElevatorBring());
            Console.WriteLine(elevator.GetStatus());
            Console.WriteLine("На який поверх їдемо?(1-12)");
            int UserFloorChoice = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(elevator.ElevatorMover(UserFloorChoice));
            Console.WriteLine(elevator.GetStatus());
            Console.WriteLine(elevator.DoorOpener());
        }
        else if (Userchoice == 2)
        {
            Console.WriteLine("Ок.");
        }
        else
        {
            Console.WriteLine("Неправильно.");
        }
        Console.WriteLine(elevator.GetStatus());
        Console.WriteLine(elevator.GetElevatorType());
        Console.WriteLine(elevator.Smell());
    }
}
    

   
   

