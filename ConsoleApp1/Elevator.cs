namespace ConsoleApp1;

public class Elevator
{
    public int CurrentFloor;
    
    public int CurrentElevatorPosition;
    
    public bool ElevatorIsOpen = false;

    public Elevator(int currentFloor, int currentElevatorPosition, bool elevatorIsOpen)
    {
        this.CurrentElevatorPosition = currentElevatorPosition;
        this.CurrentFloor = currentFloor;
        this.ElevatorIsOpen = elevatorIsOpen;
    }
    public string GetStatus()
    {
    return $"Поточний поверх: {CurrentFloor}, Поверх де знаходится ліфт: {CurrentElevatorPosition}, Двері відкриті?: {ElevatorIsOpen}";
    }
    
    public string ElevatorBring()
    {
        CurrentElevatorPosition = CurrentFloor;
        ElevatorIsOpen = !ElevatorIsOpen;
        return $"Ліфт прибув.";
    }

    public string ElevatorMover(int UserFloorChoice)
    {
        CurrentElevatorPosition = UserFloorChoice;
        CurrentFloor = UserFloorChoice;
        ElevatorIsOpen = !ElevatorIsOpen;
        return $"Ліфт прибув на {UserFloorChoice} поверх.";
    }

    public string DoorOpener()
    {
        ElevatorIsOpen = !ElevatorIsOpen;
        return $"Стан дверей був зміненний.";
    }

    public virtual string Smell()
    {
        return "У ліфті смерділо маслом.";
    }
}

