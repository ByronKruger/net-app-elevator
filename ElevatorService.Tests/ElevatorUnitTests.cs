using Elevator.Data;

namespace Elevator.Tests;

public class ElevatorUnitTests
{
    private ElevatorService _service;
    
    private void Setup(){
        _service = new ElevatorService();
        _service.AddElevator(new ElevatorDetails { IsUpDirection = true, CurrentFloor = 0 });
        _service.AddElevator(new ElevatorDetails { IsUpDirection = false, CurrentFloor = 1 });
        List<List<ElevatorRequest>> floors = new ();

        // floor 1
        List<ElevatorRequest> floor1 = new ();
        var elevatorRequestFloor1p1 = new ElevatorRequest { IsUpDirection = true, CurrentFloor = 0 };
        floor1.Add(elevatorRequestFloor1p1);
        var elevatorRequestFloor12 = new ElevatorRequest { IsUpDirection = true, CurrentFloor = 0 };
        floor1.Add(elevatorRequestFloor12);
        // var elevatorRequestFloor21 = new ElevatorRequest { IsUpDirection = false, CurrentFloor = 0 };
        // floor1.Add(elevatorRequestFloor21);
        floors.Add(floor1);
        // floor 2
        List<ElevatorRequest> floor2 = new ();
        var elevatorRequestFloor2p1 = new ElevatorRequest { IsUpDirection = true, CurrentFloor = 1 };
        floor2.Add(elevatorRequestFloor2p1);
        var elevatorRequestFloor22 = new ElevatorRequest { IsUpDirection = false, CurrentFloor = 1 };
        floor2.Add(elevatorRequestFloor22);
        var elevatorRequestFloor23 = new ElevatorRequest { IsUpDirection = true, CurrentFloor = 1 };
        floor2.Add(elevatorRequestFloor23);
        var elevatorRequestFloor24 = new ElevatorRequest { IsUpDirection = false, CurrentFloor = 1 };
        floor2.Add(elevatorRequestFloor24);
        floors.Add(floor2);
        // floor 3
        List<ElevatorRequest> floor3 = new ();
        var elevatorRequestFloor3p1 = new ElevatorRequest { IsUpDirection = false, CurrentFloor = 2 };
        floor3.Add(elevatorRequestFloor3p1);
        var elevatorRequestFloor32 = new ElevatorRequest { IsUpDirection = false, CurrentFloor = 2 };
        floor3.Add(elevatorRequestFloor32);
        var elevatorRequestFloor3p3 = new ElevatorRequest { IsUpDirection = false, CurrentFloor = 2 };
        floor3.Add(elevatorRequestFloor3p3);
        floors.Add(floor3);

        _service.AddFloors(floors);
    }

    // [Fact]
    // public void ElevatorGoesToPersonOnFloor0()
    // {
    //     Setup();
    //     var floor = _service.RequestElevatorAtFloor();
    //     Assert.Equal(0, floor);
    // }

    // [Fact]
    // public void ElevatorGoesToPersonOnFloor2()
    // {
    //     Setup();
    //     _service.SetElevator(new ElevatorDetails { IsUpDirection = true, CurrentFloor = 0 });
    //     List<List<ElevatorRequest>> floors = new ();

    //     // floor 1
    //     List<ElevatorRequest> floor1 = new ();
    //     var elevatorRequestFloor1p1 = new ElevatorRequest { IsUpDirection = true, CurrentFloor = 0 };
    //     floor1.Add(elevatorRequestFloor1p1);
    //     var elevatorRequestFloor12 = new ElevatorRequest { IsUpDirection = true, CurrentFloor = 0 };
    //     floor1.Add(elevatorRequestFloor12);
    //     var elevatorRequestFloor21 = new ElevatorRequest { IsUpDirection = false, CurrentFloor = 0 };
    //     floor1.Add(elevatorRequestFloor21);
    //     floors.Add(floor1);
    //     // floor 2
    //     List<ElevatorRequest> floor2 = new ();
    //     var elevatorRequestFloor2p1 = new ElevatorRequest { IsUpDirection = true, CurrentFloor = 1 };
    //     floor2.Add(elevatorRequestFloor2p1);
    //     var elevatorRequestFloor22 = new ElevatorRequest { IsUpDirection = false, CurrentFloor = 1 };
    //     floor2.Add(elevatorRequestFloor22);
    //     floors.Add(floor2);

    //     List<ElevatorRequest> floor3 = new ();
    //     // var elevatorRequestFloor31 = new ElevatorRequest { IsUpDirection = false, CurrentFloor = 2 };
    //     // floor2.Add(elevatorRequestFloor31);
    //     floors.Add(floor3);

    //     _service.AddFloors(floors);

    //     _service.Elevate();
    //     var latestElevatorStatus = _service.GetElevator();
    //     Console.WriteLine("***************");
    //     Console.WriteLine(latestElevatorStatus.CurrentFloor);
    //     Console.WriteLine(latestElevatorStatus.IsUpDirection);
    //     Console.WriteLine(latestElevatorStatus.IsMoving);
    //     Assert.Equal(0, latestElevatorStatus.CurrentFloor);
    //     Assert.Equal(false, latestElevatorStatus.IsMoving);

    //     _service.Elevate();
    //     latestElevatorStatus = _service.GetElevator();
    //     Console.WriteLine("***************");
    //     Console.WriteLine(latestElevatorStatus.CurrentFloor);
    //     Console.WriteLine(latestElevatorStatus.IsUpDirection);
    //     Console.WriteLine(latestElevatorStatus.IsMoving);
    //     Assert.Equal(0, latestElevatorStatus.CurrentFloor);
    //     Assert.Equal(true, latestElevatorStatus.IsMoving);

    //     _service.Elevate();
    //     latestElevatorStatus = _service.GetElevator();
    //     Console.WriteLine("***************");
    //     Console.WriteLine(latestElevatorStatus.CurrentFloor);
    //     Console.WriteLine(latestElevatorStatus.IsUpDirection);
    //     Console.WriteLine(latestElevatorStatus.IsMoving);
    //     Assert.Equal(1, latestElevatorStatus.CurrentFloor);
    //     Assert.Equal(true, latestElevatorStatus.IsMoving);
    // }

    // [Fact]
    // public void ElevatorChangesDirection_whenAtEnd()
    // {
    //     Setup();
    //     _service.SetElevator(new ElevatorDetails { IsUpDirection = true, CurrentFloor = 0 });
    //     List<List<ElevatorRequest>> floors = new ();

    //     // floor 1
    //     List<ElevatorRequest> floor1 = new ();
    //     var elevatorRequestFloor1p1 = new ElevatorRequest { IsUpDirection = true, CurrentFloor = 0 };
    //     floor1.Add(elevatorRequestFloor1p1);
    //     var elevatorRequestFloor12 = new ElevatorRequest { IsUpDirection = true, CurrentFloor = 0 };
    //     floor1.Add(elevatorRequestFloor12);
    //     floors.Add(floor1);
    //     // floor 2
    //     List<ElevatorRequest> floor2 = new ();
    //     var elevatorRequestFloor2p1 = new ElevatorRequest { IsUpDirection = true, CurrentFloor = 1 };
    //     floor2.Add(elevatorRequestFloor2p1);
    //     var elevatorRequestFloor22 = new ElevatorRequest { IsUpDirection = false, CurrentFloor = 1 };
    //     floor2.Add(elevatorRequestFloor22);
    //     floors.Add(floor2);
    //     // floor 3
    //     List<ElevatorRequest> floor3 = new ();
    //     var elevatorRequestFloor3p1 = new ElevatorRequest { IsUpDirection = false, CurrentFloor = 2 };
    //     floor3.Add(elevatorRequestFloor3p1);
    //     var elevatorRequestFloor32 = new ElevatorRequest { IsUpDirection = false, CurrentFloor = 2 };
    //     floor3.Add(elevatorRequestFloor32);
    //     floors.Add(floor3);

    //     _service.AddFloors(floors);

    //     var latestElevatorStatus = _service.GetElevator();// down 0
    //     latestElevatorStatus = _service.GetElevator();
    //     Assert.Equal(false, latestElevatorStatus.IsUpDirection);

    //     _service.Elevate();
    //     latestElevatorStatus = _service.GetElevator(); // up 1
    //     Assert.Equal(1, latestElevatorStatus.CurrentFloor);
    //     Assert.Equal(false, latestElevatorStatus.IsMoving);
    //     Assert.Equal(true, latestElevatorStatus.IsUpDirection);

    //     _service.Elevate();
    //     latestElevatorStatus = _service.GetElevator(); // down 0
    //     Assert.Equal(2, latestElevatorStatus.CurrentFloor);
    //     Assert.Equal(false, latestElevatorStatus.IsMoving);
    //     Assert.Equal(true, latestElevatorStatus.IsUpDirection);

    //     _service.Elevate();
    //     latestElevatorStatus = _service.GetElevator();
    //     Assert.Equal(1, latestElevatorStatus.CurrentFloor);
    //     Assert.Equal(false, latestElevatorStatus.IsMoving);
    //     Assert.Equal(false, latestElevatorStatus.IsUpDirection);

    //     _service.Elevate();
    //     latestElevatorStatus = _service.GetElevator();
    //     Assert.Equal(1, latestElevatorStatus.CurrentFloor);
    //     Assert.Equal(false, latestElevatorStatus.IsMoving);
    //     Assert.Equal(false, latestElevatorStatus.IsUpDirection);

    //     _service.Elevate();
    //     latestElevatorStatus = _service.GetElevator();

    //     _service.Elevate();
    //     latestElevatorStatus = _service.GetElevator();
    // }

    [Fact]
    public void TwoElevatorsServicePoolOfRequests()
    {
        Setup();
        var latestElevatorStatuses = _service.GetElevators(); // down 0 (e0)
        Assert.Equal(true, latestElevatorStatuses.ElementAt(0).IsUpDirection); // starting direction
        Assert.Equal(0, latestElevatorStatuses.ElementAt(0).CurrentFloor); // starting pos
        Assert.Equal(false, latestElevatorStatuses.ElementAt(1).IsUpDirection); // "
        Assert.Equal(1, latestElevatorStatuses.ElementAt(1).CurrentFloor); // "

        _service.ElevateAll();

        latestElevatorStatuses = _service.GetElevators(); // up 1
        Assert.Equal(true, latestElevatorStatuses.ElementAt(0).IsUpDirection); // changed direction
        Assert.Equal(1, latestElevatorStatuses.ElementAt(0).CurrentFloor); // up 1 (e0)
        Assert.Equal(false, latestElevatorStatuses.ElementAt(1).IsUpDirection); // down 0 (e1)
        Assert.Equal(0, latestElevatorStatuses.ElementAt(1).CurrentFloor);

        _service.ElevateAll();

        latestElevatorStatuses = _service.GetElevators(); // up 1
        Assert.Equal(true, latestElevatorStatuses.ElementAt(0).IsUpDirection);
        Assert.Equal(2, latestElevatorStatuses.ElementAt(0).CurrentFloor); // up 2 (e0)
        Assert.Equal(true, latestElevatorStatuses.ElementAt(1).IsUpDirection);
        Assert.Equal(1, latestElevatorStatuses.ElementAt(1).CurrentFloor);
    }
}