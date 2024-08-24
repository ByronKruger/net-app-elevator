namespace Elevator.Data;

public class ElevatorDetails : Elevator
{
    public List<ElevatorRequest> PeopleCarrying {get; set;} = new ();
    public bool IsMoving {get; set;}
    public bool IsAtCapacity {get; set;}
}