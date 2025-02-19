namespace ConsoleApp1;

public class ElevatorType : Elevator
{
    public int YearOfCreation;
    
    public string InteriorStyle;

    public float MaxSpeed;

    public ElevatorType(int YearOfCreation, string interiorStyle, float maxSpeed, int currentFloor, 
        int currentElevatorPosition, bool elevatorIsOpen) : base(currentFloor, currentElevatorPosition, elevatorIsOpen)
    {
        this.YearOfCreation = YearOfCreation;
        this.InteriorStyle = interiorStyle;
        this.MaxSpeed = maxSpeed;
    }

    public string GetElevatorType()
    {
        return $"Рік побудови ліфту: {YearOfCreation}, Стиль інтерьеру: {InteriorStyle}, Максимальна швидкість: {MaxSpeed}.";
    }
    public override string Smell()
    {
        return "У ліфті нічим не смерділо."; 
    }
}
