using Elevator.Data;

namespace Elevator.Tests;

public class ElevatorUnitTestsVer1
{
    // private ElevatorService _service;
    
    // private void Setup(){
    //     _service = new ElevatorService();
    // }

    // [Fact]
    // public void ElevatorAtPersonSingleFloor()
    // {
    //     Setup();
    //     var floor = _service.RequestElevatorAndPickupPerson();
    //     Assert.Equal(floor, 0);
    // }

    // [Fact]
    // public void ElevatorAtPersonOnFloor2_Or1()
    // {
    //     Setup();
    //     var floor = _service.RequestElevatorAndPickupPerson(0);
    //     Assert.Equal(floor, 0);
    //     floor = _service.RequestElevatorAndPickupPerson(1);
    //     Assert.Equal(floor, 1);
    // }

    // [Fact]
    // public void ElevatorAtPersonOnFloor2_whenPersonOn1()
    // {
    //     Setup();
    //     var floor = _service.RequestElevatorAndPickupPerson(1);
    //     Assert.Equal(floor, 1);
    // }

    // [Fact]
    // public void ElevatorAtPersonOnFloor2_whenPersonOn2()
    // {
    //     Setup();
    //     var floor = _service.RequestElevatorAndPickupPerson(1);
    //     Assert.Equal(floor, 1);
    // }

    // [Fact]
    // public void CanAddFloors_For3rdFloor()
    // {
    //     Setup();
    //     _service.AddFloor();
    //     var floorCount = _service.GetFloors();
    //     Assert.Equal(floorCount.Count(), 3);
    // }

    // [Fact]
    // public void ElevatorAtFloor1_whenPersonAtFloor2()
    // {
    //     Setup();
    //     var personFloor = _service.RequestElevatorAndPickupPerson(1);
    //     Assert.Equal(personFloor, 1);
    //     var elevatorFloor = _service.GetCurrentFloor();
    //     Assert.Equal(elevatorFloor, 0);
    // }

    // [Fact]
    // public void ElevatorAtFloor2_whenPersonAtFloor1()
    // {
    //     Setup();
    //     var personFloor = _service.RequestElevatorAndPickupPerson(0);
    //     Assert.Equal(personFloor, 0);
    //     _service.SetCurrentFloor(1);
    //     var elevatorFloor = _service.GetCurrentFloor();
    //     Assert.Equal(elevatorFloor, 1);
    // }

    // [Fact]
    // public void ElevatorAtFloor2_whenTwoPersons_at1And2()
    // {
    //     Setup();
    //     _service.AddPerson(0);
    //     _service.AddPerson(1);
    //     var persons = _service.GetPersons();
    //     Assert.Equal(persons.ElementAt(0), 0);
    //     Assert.Equal(persons.ElementAt(1), 1);

    //     _service.SetCurrentFloor(1);
    //     var elevatorFloor = _service.GetCurrentFloor();
    //     Assert.Equal(elevatorFloor, 1);
    // }

    // [Fact]
    // public void ElevatorAtFloor1_goesToMostEfficientFloor_between2Persons_at1And2()
    // {
    //     Setup();
    //     _service.SetCurrentFloor(0);
    //     _service.AddPerson(0);
    //     _service.AddPerson(1);

    //     var personFloor = _service.RequestElevatorAndPickupPerson(0);
    //     Assert.Equal(personFloor, 0);
    // }

    // [Fact]
    // public void ElevatorAtFloor3_goesToPersons_OnFloor1()
    // {
    //     Setup();
    //     _service.SetCurrentFloor(2);
    //     _service.AddPerson(1);
    //     // _service.AddPerson(2);

    //     var personFloor = _service.RequestElevatorAndPickupPerson(0);
    //     Assert.Equal(personFloor, 0);
    // }

    // [Fact]
    // public void ElevatorAt1_goesToMostEfficientPerson_at2_and3() // upwards
    // {
    //     Setup();
    //     _service.SetCurrentFloor(0);
    //     _service.AddPerson(2);
    //     _service.AddPerson(1);

    //     var newElevatorFloor = _service.RequestElevatorAndPickupPerson(_service.GetPersons(), true);
    //     Assert.Equal(newElevatorFloor, 1);
    // }

    // [Fact]
    // public void ElevatorAt3_goesToMostEfficientPerson_at1_and2() // downwards
    // {
    //     Setup();
    //     _service.SetCurrentFloor(2);
    //     _service.AddPerson(1);
    //     _service.AddPerson(0);

    //     var newElevatorFloor = _service.RequestElevatorAndPickupPerson(_service.GetPersons(), false);
    //     Assert.Equal(newElevatorFloor, 1);
    // }

    // [Fact]
    // public void ElevatorAt3_goesToMostEfficientPerson_at1_and5_goingDownwards() // downwards
    // {
    //     Setup();
    //     _service.SetCurrentFloor(2);
    //     _service.AddPerson(0);
    //     _service.AddPerson(4);

    //     var newElevatorFloor = _service.RequestElevatorAndPickupPerson(_service.GetPersons(), false);
    //     Assert.Equal(newElevatorFloor, 0);
    // }

    // [Fact]
    // public void ElevatorAt2_goesToMostEfficientPerson_at1_and5() // downwards
    // {
    //     Setup();
    //     _service.SetCurrentFloor(2);
    //     _service.AddPerson(0);
    //     _service.AddPerson(4);

    //     var newElevatorFloor = _service.RequestElevatorAndPickupPerson(_service.GetPersons(), false);
    //     Assert.Equal(newElevatorFloor, 4);
    // }

    // [Fact]
    // public void ElevatorAt2_goesToMostEfficientPerson_at1_and4() // downwards
    // {
    //     Setup();
    //     _service.SetCurrentFloor(3);
    //     _service.AddPerson(0);
    //     _service.AddPerson(3);

    //     _service.RequestElevatorAndPickupPerson(_service.GetPersons());
    //     var newElevatorFloor = _service.GetCurrentFloor();
    //     Assert.Equal(newElevatorFloor, 3);

    //     Setup();
    //     _service.SetCurrentFloor(1);
    //     _service.AddPerson(0);
    //     _service.AddPerson(3);

    //     _service.RequestElevatorAndPickupPerson(_service.GetPersons());
    //     newElevatorFloor = _service.GetCurrentFloor();
    //     Assert.Equal(newElevatorFloor, 0);

    //     Setup();
    //     _service.SetCurrentFloor(0);
    //     _service.AddPerson(2);
    //     _service.AddPerson(3);

    //     _service.RequestElevatorAndPickupPerson(_service.GetPersons());
    //     newElevatorFloor = _service.GetCurrentFloor();
    //     Assert.Equal(newElevatorFloor, 2);
    // }

    // public void ElevatorHandlesPersonGoingUp() // upwards
    // {
    //     Setup();
    //     _service.SetElevator(new ElevatorDetails { CurrentFloor = 0, IsUpDirection = true});
    //     _service.AddPerson(new ElevatorRequest { IsUpDirection = false, CurrentFloor = 0});
    //     _service.AddPerson(new ElevatorRequest { IsUpDirection = true, CurrentFloor = 2});
    //     _service.AddPerson(new ElevatorRequest { IsUpDirection = true, CurrentFloor = 3});

    //     _service.RequestElevatorAndPickupPerson(_service.GetPersons());
    //     var newElevatorFloor = _service.GetElevator().CurrentFloor;
    //     Assert.Equal(2, newElevatorFloor);
    // }

    // [Fact]
    // public void ElevatorHandlesPersonGoingDown() // upwards
    // {
    //     Setup();
    //     _service.SetElevator(new ElevatorDetails { CurrentFloor = 2, IsUpDirection = false});
    //     _service.AddPerson(new ElevatorRequest { IsUpDirection = false, CurrentFloor = 0});
    //     _service.AddPerson(new ElevatorRequest { IsUpDirection = false, CurrentFloor = 1});
    //     _service.AddPerson(new ElevatorRequest { IsUpDirection = true, CurrentFloor = 2});
    //     _service.AddPerson(new ElevatorRequest { IsUpDirection = false, CurrentFloor = 3});

    //     _service.RequestElevatorAndPickupPerson(_service.GetPersons());
    //     var newElevatorFloor = _service.GetElevator().CurrentFloor;
    //     Assert.Equal(1, newElevatorFloor);
    // }

    // [Fact]
    // public void ElevatorHandlesMultipleRequests() // up/down
    // {
    //     Setup();
    //     _service.SetElevator(new ElevatorDetails { CurrentFloor = 2, IsUpDirection = false});
    //     _service.AddPerson(new ElevatorRequest { IsUpDirection = false, CurrentFloor = 3});
    //     _service.AddPerson(new ElevatorRequest { IsUpDirection = false, CurrentFloor = 2});
    //     _service.AddPerson(new ElevatorRequest { IsUpDirection = true, CurrentFloor = 1});
    //     _service.AddPerson(new ElevatorRequest { IsUpDirection = false, CurrentFloor = 0});

    //     _service.RequestElevatorAndPickupPerson(_service.GetPersons());
    //     var newElevatorFloor = _service.GetElevator().CurrentFloor;
    //     Assert.Equal(2, newElevatorFloor);

    //     _service.RequestElevatorAndPickupPerson(_service.GetPersons());
    //     newElevatorFloor = _service.GetElevator().CurrentFloor;
    //     Assert.Equal(0, newElevatorFloor);
    // }

    // [Fact]
    // public void ElevatorChangeDirection_whenNoPerson_inDirection()
    // {
    //     Setup();
    //     _service.SetElevator(new ElevatorDetails { CurrentFloor = 2, IsUpDirection = false});
    //     _service.AddPerson(new ElevatorRequest { IsUpDirection = false, CurrentFloor = 3});
    //     // _service.AddPerson(new ElevatorRequest { IsUpDirection = false, CurrentFloor = 2});
    //     // _service.AddPerson(new ElevatorRequest { IsUpDirection = true, CurrentFloor = 1});
    //     // _service.AddPerson(new ElevatorRequest { IsUpDirection = false, CurrentFloor = 0});

    //     _service.RequestElevatorAndPickupPerson(_service.GetPersons());
    //     var newElevatorDirection = _service.GetElevator().IsUpDirection;
    //     Assert.Equal(true, newElevatorDirection);
    // }

    // [Fact]
    // public void ElevatorAddsPeople_whenSameFloor()
    // {
    //     Setup();
    //     _service.SetElevator(new ElevatorDetails { CurrentFloor = 2, IsUpDirection = false});
    //     _service.AddPerson(new ElevatorRequest { IsUpDirection = false, CurrentFloor = 3});
    //     // _service.AddPerson(new ElevatorRequest { IsUpDirection = false, CurrentFloor = 2});
    //     // _service.AddPerson(new ElevatorRequest { IsUpDirection = true, CurrentFloor = 1});
    //     _service.AddPerson(new ElevatorRequest { IsUpDirection = false, CurrentFloor = 0});

    //     var newElevatorPeople = _service.GetElevator().PeopleCarrying;
    //     Assert.Equal(0, newElevatorPeople.Count());

    //     _service.RequestElevatorAndPickupPerson();
    //     newElevatorPeople = _service.GetElevator().PeopleCarrying;
    //     Assert.Equal(1, newElevatorPeople.Count());
    // }

    // [Fact]
    // public void ElevatorReleasesPeople_whenSameFloor()
    // {
    //     Setup();
    //     _service.SetElevator(new ElevatorDetails { CurrentFloor = 2, IsUpDirection = true});
    //     // _service.AddPerson(new ElevatorRequest { IsUpDirection = true, CurrentFloor = 3});
    //     // _service.AddPerson(new ElevatorRequest { IsUpDirection = false, CurrentFloor = 2});
    //     // _service.AddPerson(new ElevatorRequest { IsUpDirection = true, CurrentFloor = 1});
    //     // _service.AddPerson(new ElevatorRequest { IsUpDirection = false, CurrentFloor = 0});

    //     _service.AddPeopleCarrying(new ElevatorRequest { CurrentFloor = 1, IsUpDirection = true, FloorGoing = 2});
    //     var newElevatorPeople = _service.GetElevator().PeopleCarrying;
    //     Assert.Equal(1, newElevatorPeople.Count());

    //     _service.RequestElevatorAndPickupPerson();
    //     newElevatorPeople = _service.GetElevator().PeopleCarrying;
    //     Assert.Equal(0, newElevatorPeople.Count());
    // }

    // [Fact]
    // public void ElevatorContinueAddsPeople_untilEnd()
    // {
    //     Setup();
    //     _service.SetElevator(new ElevatorDetails { CurrentFloor = 2, IsUpDirection = false});
    //     _service.AddPerson(new ElevatorRequest { IsUpDirection = false, CurrentFloor = 3});
    //     _service.AddPerson(new ElevatorRequest { IsUpDirection = false, CurrentFloor = 1});
    //     _service.AddPerson(new ElevatorRequest { IsUpDirection = false, CurrentFloor = 2});
    //     _service.AddPerson(new ElevatorRequest { IsUpDirection = false, CurrentFloor = 0});

    //     // _service.AddPeopleCarrying(new ElevatorRequest { CurrentFloor = 1, IsUpDirection = true, FloorGoing = 2});
    //     // var newElevatorPeople = _service.GetElevator().PeopleCarrying;
    //     // Assert.Equal(1, newElevatorPeople.Count());

    //     _service.RequestElevatorAndPickupPerson();
    //     var newElevatorPeople = _service.GetElevator().PeopleCarrying;
    //     Assert.Equal(1, newElevatorPeople.Count());
    //     var newElevatorFloor = _service.GetElevator().CurrentFloor;
    //     Assert.Equal(2, newElevatorFloor);

    //     _service.RequestElevatorAndPickupPerson();
    //     newElevatorPeople = _service.GetElevator().PeopleCarrying;
    //     Assert.Equal(2, newElevatorPeople.Count());
    //     newElevatorFloor = _service.GetElevator().CurrentFloor;
    //     Assert.Equal(1, newElevatorFloor);

    //     _service.RequestElevatorAndPickupPerson();
    //     newElevatorPeople = _service.GetElevator().PeopleCarrying;
    //     Assert.Equal(3, newElevatorPeople.Count());
    //     newElevatorFloor = _service.GetElevator().CurrentFloor;
    //     Assert.Equal(0, newElevatorFloor);
    // }

    // public List<ElevatorRequest> GetPersons()
    // {
    //     return _persons;
    // }
    // private List<ElevatorRequest> _persons = new List<ElevatorRequest>();
    
    // public void AddPerson(ElevatorRequest request)
    // {
    //     if (request.CurrentFloor < _floors.Count())
    //         _persons.Add(request);
    // }
}