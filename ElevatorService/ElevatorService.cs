using System;
using Elevator.Data;

namespace Elevator;

public class ElevatorService
{
    private ElevatorDetails _elevator;
    private List<List<ElevatorRequest>> _floors = new ();
    private List<ElevatorDetails> _elevators = new ();
    private bool changedDirection = false;
    private readonly int ELEVATOR_MAX_CAPACITY = 5; // 12

    private void SetDirection(int elevatorIndex)
    {
        if (changedDirection) 
        {
            changedDirection = false;
        }

        if ((_elevators.ElementAt(elevatorIndex).CurrentFloor == 0 && !_elevators.ElementAt(elevatorIndex).IsUpDirection) || 
            (_elevators.ElementAt(elevatorIndex).CurrentFloor == _floors.Count() - 1 && _elevators.ElementAt(elevatorIndex).IsUpDirection))
        {
            changedDirection = true;
            _elevators.ElementAt(elevatorIndex).IsUpDirection = !_elevators.ElementAt(elevatorIndex).IsUpDirection;
        }
    }

    private void MoveElevator(int elevatorIndex)
    {
        if (changedDirection)
        {
            SetDirection(elevatorIndex);
        }
        else 
        {
            SetDirection(elevatorIndex);
            if (!_elevators.ElementAt(elevatorIndex).IsUpDirection) 
            {
                _elevators.ElementAt(elevatorIndex).CurrentFloor -= 1;
            }
            else
            {
                _elevators.ElementAt(elevatorIndex).CurrentFloor += 1;
            }
        }
    }

    public void ElevateAll() {
        for (int i = 0; i < _elevators.Count(); i++)
            Elevate(i);
    }
    
    public void Elevate(int elevatorIndex)
    {
        List<int> requestsToRemove = new ();
        List<ElevatorRequest> newFloorRequests = new ();

        if (_floors.ElementAt(_elevators.ElementAt(elevatorIndex).CurrentFloor).Count() == 0) 
        {
            _elevators.ElementAt(elevatorIndex).IsMoving = true;
            MoveElevator(elevatorIndex);
            return;
        }

        var noneInSameDirection = true;
        int totalRemoveAmount = 0;

        for (int i = 0; i < _floors.ElementAt(_elevators.ElementAt(elevatorIndex).CurrentFloor).Count(); i++) 
        {
            if (_floors.ElementAt(_elevators.ElementAt(elevatorIndex).CurrentFloor).ElementAt(i).IsUpDirection == _elevators.ElementAt(elevatorIndex).IsUpDirection)
            {
                noneInSameDirection = false;
                _elevators.ElementAt(elevatorIndex).IsMoving = false;

                if (totalRemoveAmount + _elevators.ElementAt(elevatorIndex).PeopleCarrying.Count() <= ELEVATOR_MAX_CAPACITY) 
                {
                    _elevators.ElementAt(elevatorIndex).PeopleCarrying.Add(_floors.ElementAt(_elevators.ElementAt(elevatorIndex).CurrentFloor).ElementAt(i));
                    totalRemoveAmount += 1;
                }
                else 
                {
                    _elevators.ElementAt(elevatorIndex).IsAtCapacity = true;
                    _elevators.ElementAt(elevatorIndex).IsMoving = false;
                    break;
                }
            }
        }
        
        int removeCount = 0;
        _floors.ElementAt(_elevators.ElementAt(elevatorIndex).CurrentFloor).RemoveAll(r => 
            {
                removeCount += 1;
                return (r.IsUpDirection == _elevators.ElementAt(elevatorIndex).IsUpDirection) &&
                    removeCount <= totalRemoveAmount;
            }
        );

        if (noneInSameDirection)
        {
            _elevators.ElementAt(elevatorIndex).IsMoving = true;
            MoveElevator(elevatorIndex);
            return;
        }
        MoveElevator(elevatorIndex);
    }

    public void AddPeopleCarrying(ElevatorRequest person) 
    {
        _elevator.PeopleCarrying.Add(person);
    }

    public List<List<ElevatorRequest>> GetFloors()
    {
        return _floors;
    }

    public void AddElevatorRequest(ElevatorRequest request)
    {
        _floors.ElementAt(request.CurrentFloor).Add(request);
    }

    public void SetElevator(ElevatorDetails elevator)
    {
        _elevator = elevator;
    }

    public ElevatorDetails GetElevator()
    {
        return _elevator;
    }

        public List<ElevatorDetails> GetElevators()
    {
        return _elevators;
    }

    public void AddFloors(List<List<ElevatorRequest>> floors)
    {
        _floors = floors;
    }

    public void AddElevator(ElevatorDetails elevator)
    {
        _elevators.Add(elevator);
    }
}















//     public void RequestElevatorAndPickupPerson()//List<ElevatorRequest> elevatorRequests)
//     {
//         var nextPersonIndex = 0;
//         var placeholderFloor = 0;
//         var personExists = false;

//         // Console.WriteLine("_elevator.PeopleCarrying.Count()");
//         // Console.WriteLine(_elevator.PeopleCarrying.Count());
//         for (var i = 0; i < _elevator.PeopleCarrying.Count(); i++)
//         {
//             // Console.WriteLine("=======================================");
//             // Console.WriteLine("_elevator.PeopleCarrying.ElementAt(i).FloorGoing");
//             // Console.WriteLine(_elevator.PeopleCarrying.ElementAt(i).FloorGoing);
//             // Console.WriteLine("_elevator.CurrentFloor");
//             // Console.WriteLine(_elevator.CurrentFloor);
//             // Console.WriteLine("_elevator.PeopleCarrying.ElementAt(i).FloorGoing");
//             // Console.WriteLine(_elevator.PeopleCarrying.ElementAt(i).FloorGoing);
//             // Console.WriteLine("=======================================");
// // if (_elevator.PeopleCarrying.ElementAt(i).FloorGoing == _elevator.CurrentFloor) 
// // {
// //     _elevator.PeopleCarrying.RemoveAt(i);
// // }
//         }
//         // Console.WriteLine("_elevator.PeopleCarrying.Count()");
//         // Console.WriteLine(_elevator.PeopleCarrying.Count());

//         // for (var i = 0; i < _persons.Count(); i++)
//         // {
//             // Console.WriteLine("\n_persons[i].CurrentFloor::::::::::::::::::::::::::::::::::::::::::::");
//             // Console.WriteLine(i);
//             // Console.WriteLine(_persons[i].CurrentFloor);
//             // Console.WriteLine("_persons[i].IsUpDirection");
//             // Console.WriteLine(_persons[i].IsUpDirection);
//         // }
        
//         for (var i = 0; i < _persons.Count(); i++)
//         {
//             // if (_elevator.CurrentFloor == _persons[i].CurrentFloor) 
//             // // {
//             //     // take person to elevator (if capacity)
//             //     return;
//             // // }
//             // else
//             // {
//                 // placeholderFloor = _elevator.CurrentFloor;
//             // }
//             if ((_elevator.IsUpDirection && _persons[i].CurrentFloor >= _elevator.CurrentFloor && _persons[i].IsUpDirection) ||
//                 (!_elevator.IsUpDirection && _persons[i].CurrentFloor <= _elevator.CurrentFloor && !_persons[i].IsUpDirection))
//             {
//                 placeholderFloor = _persons[i].CurrentFloor;
//                 nextPersonIndex = i;
//                 break;
//             }
//             // else if (!_elevator.IsUpDirection && elevatorRequests[i].CurrentFloor <= _elevator.CurrentFloor) 
//             // {
//             //     placeholderFloor = elevatorRequests[i].CurrentFloor;
//             //     break;
//             // }
//         }
//         // Console.WriteLine("placeholderFloor");
//         // Console.WriteLine(placeholderFloor);
//         // for (var i = 0; i < _persons.Count(); i++)
//         // {
//         //     if (_elevator.IsUpDirection == _persons[i].IsUpDirection)
//         //     {
//         //         placeholderFloor = Math.Abs(_elevator.CurrentFloor - _persons[i].CurrentFloor);
//         //         break;
//         //     }
//         // }    

//         for (var i = 0; i < _persons.Count(); i++)
//         {
//             // Console.WriteLine("\n>>>>>>>>>>>>>>>>>>_persons[i].IsUpDirection");
//             // Console.WriteLine(_persons[i].IsUpDirection);
//             // Console.WriteLine(">>>>>>>>>>>>>>>>>>elevatorRequests[i].CurrentFloor");
//             // Console.WriteLine(elevatorRequests[i].CurrentFloor);
//             // Console.WriteLine(">>>>>>>>>>>>>>>>>>placeholderFloor");
//             // Console.WriteLine(placeholderFloor);
//             if (((_elevator.IsUpDirection && _persons[i].CurrentFloor <= placeholderFloor) && _persons[i].IsUpDirection) && 
//                 (_persons[i].CurrentFloor >= _elevator.CurrentFloor) ||
//                 ((!_elevator.IsUpDirection && _persons[i].CurrentFloor >= placeholderFloor) && !_persons[i].IsUpDirection) && 
//                 (_persons[i].CurrentFloor <= _elevator.CurrentFloor))
//             {
//                 // Console.WriteLine("\n_elevator.IsUpDirection");
//                 // Console.WriteLine(_elevator.IsUpDirection);
//                 // Console.WriteLine("\n::::levatorRequests[i].CurrentFloor");
//                 // Console.WriteLine(_persons[i].CurrentFloor);
//                 // Console.WriteLine("::::placeholderFloor");
//                 // Console.WriteLine(placeholderFloor);
//                 placeholderFloor = _persons[i].CurrentFloor;
//                 // Console.WriteLine(":::: :::: :::: :::: :::: :::: ::: :::: ;;; i");
//                 // Console.WriteLine(i);
//                 nextPersonIndex = i;
//                 personExists = true;
//             }
//             // Console.WriteLine("\n=============================");
//             // Console.WriteLine("placeholderFloor");
//             // Console.WriteLine(placeholderFloor);
//             // Console.WriteLine("=============================");
            
//             // if (_elevator.IsUpDirection && (elevatorRequests[i].CurrentFloor < elevatorRequests[i].CurrentFloor + _elevator.CurrentFloor))
//             //     placeholderFloor = elevatorRequests[i].CurrentFloor;
//             // else if (!_elevator.IsUpDirection && (elevatorRequests[i].CurrentFloor > elevatorRequests[i].CurrentFloor - _elevator.CurrentFloor))

//             // if (_elevator.IsUpDirection && (elevatorRequests[i].CurrentFloor < placeholderFloor))
//             //     placeholderFloor = elevatorRequests[i].CurrentFloor;
//             // else if (!_elevator.IsUpDirection && (elevatorRequests[i].CurrentFloor > elevatorRequests[i].CurrentFloor - _elevator.CurrentFloor))
//         }
//         // for (var i = 0; i < _persons.Count(); i++)
//         // {
//         //     if ((_elevator.IsUpDirection == _persons[i].IsUpDirection) && 
//         //         (Math.Abs(_elevator.CurrentFloor - _persons[i].CurrentFloor) <= placeholderFloor))
//         //     {
//         //         placeholderFloor = Math.Abs(_elevator.CurrentFloor - _persons[i].CurrentFloor);
//         //         nextPersonIndex = i;
//         //     }
//         // }

//         // if (placeholderFloor > _elevator.CurrentFloor)
//         // {
//         //     _elevator.CurrentFloor += placeholderFloor;
//         // }
//         // else 
//         // {
//         // Console.WriteLine("\n\n_elevator");
//         // Console.WriteLine(_elevator);
//         // Console.WriteLine("_elevator CurrentFloor");
//         // Console.WriteLine(_elevator.CurrentFloor);
//         // _elevator = new ElevatorDetails 
//         // {
//         //     IsUpDirection = _elevator.IsUpDirection,
//         //     CurrentFloor = placeholderFloor
//         // }; 
//         _elevator.CurrentFloor = placeholderFloor; 
//         // SetElevator(_elevator); 
//         // Console.WriteLine("\n\n_elevator");
//         // Console.WriteLine(_elevator);
//         // Console.WriteLine("GetElevator().CurrentFloor");
//         // Console.WriteLine("_elevator CurrentFloor");
//         // Console.WriteLine(_elevator.CurrentFloor);
//         // }
//         // Console.WriteLine("\nplaceholderFloor");
//         // Console.WriteLine(placeholderFloor);
//         // return placeholderFloor;
//         // Console.WriteLine("\nextPersonIndex");
//         // Console.WriteLine(nextPersonIndex);
//         if (personExists)
//         {
//             _elevator.PeopleCarrying.Add(_persons.ElementAt(nextPersonIndex));
//             _persons.RemoveAt(nextPersonIndex);
//         }
        
//         if (!personExists)
//         {
//             _elevator.IsUpDirection = !_elevator.IsUpDirection;
//         }
//         // for (var i = 0; i < _persons.Count(); i++)
//         // {
//             // Console.WriteLine("\n_persons[i].CurrentFloor::::::::::::::::::::::::::::::::::::::::::::");
//             // Console.WriteLine(i);
//             // Console.WriteLine(_persons[i].CurrentFloor);
//             // Console.WriteLine("_persons[i].IsUpDirection");
//             // Console.WriteLine(_persons[i].IsUpDirection);
//         // }
//         // _persons.RemoveAt(nextPersonIndex);
//     }