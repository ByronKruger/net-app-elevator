using Elevator;
using Elevator.Data;
using System;
using System.Timers;

namespace ConsoleApp;

class Program
{
    static void Main()
    {
        var _service = new ElevatorService();
        _service.AddElevator(new ElevatorDetails { IsUpDirection = true, CurrentFloor = 0 });
        _service.AddElevator(new ElevatorDetails { IsUpDirection = false, CurrentFloor = 1 });
        List<List<ElevatorRequest>> floors = new ();

        // floor 1
        List<ElevatorRequest> floor1 = new ();
        var elevatorRequestFloor1p1 = new ElevatorRequest { IsUpDirection = true, CurrentFloor = 0 };
        floor1.Add(elevatorRequestFloor1p1);
        var elevatorRequestFloor12 = new ElevatorRequest { IsUpDirection = true, CurrentFloor = 0 };
        floor1.Add(elevatorRequestFloor12);
        floors.Add(floor1);
        // floor 2
        List<ElevatorRequest> floor2 = new ();
        var elevatorRequestFloor2p1 = new ElevatorRequest { IsUpDirection = true, CurrentFloor = 1 };
        floor2.Add(elevatorRequestFloor2p1);
        var elevatorRequestFloor22 = new ElevatorRequest { IsUpDirection = false, CurrentFloor = 1 };
        floor2.Add(elevatorRequestFloor22);
        floors.Add(floor2);
        // floor 3
        List<ElevatorRequest> floor3 = new ();
        var elevatorRequestFloor3p1 = new ElevatorRequest { IsUpDirection = false, CurrentFloor = 2 };
        floor3.Add(elevatorRequestFloor3p1);
        var elevatorRequestFloor32 = new ElevatorRequest { IsUpDirection = false, CurrentFloor = 2 };
        floor3.Add(elevatorRequestFloor32);
        floors.Add(floor3);

        _service.AddFloors(floors);

        string requestFloor = "0";
        string requestDirectionTemp = "u";
        bool requestDirection = false;
        string status = "";
        ElevatorRequest elevatorRequest;
        List<ElevatorDetails> latestElevatorStatuses;

        while(status == "" || status == "a")
        {
            Console.WriteLine("Continue(Enter), quit(q) or add new request to floor(a)?");
            status = Console.ReadLine();

            if (status == "a")
            {
                Console.WriteLine($"For which floor? 0-{_service.GetFloors().Count()}?");
                requestFloor = Console.ReadLine();
                Console.WriteLine($"In which direction, up(u) or down(d)?");
                requestDirectionTemp = Console.ReadLine();
                requestDirection = requestDirectionTemp == "u" || requestDirectionTemp == "U" ? true : false; 
                elevatorRequest = new ElevatorRequest { IsUpDirection = requestDirection, CurrentFloor = Int32.Parse(requestFloor) };
                _service.AddElevatorRequest(elevatorRequest);
            }

            latestElevatorStatuses = _service.GetElevators(); // up 1
            Console.WriteLine("Latest Elevator(s):");
            for (int i = 0; i < _service.GetElevators().Count(); i++) {
                Console.WriteLine($"Elevator {i}'s current floor: " + latestElevatorStatuses.ElementAt(i).CurrentFloor);
                Console.WriteLine($"Elevator {i}'s direction: " + latestElevatorStatuses.ElementAt(i).IsUpDirection);
                Console.WriteLine($"Elevator {i}'s moving status: " + latestElevatorStatuses.ElementAt(i).IsMoving);
                if (latestElevatorStatuses.ElementAt(i).IsAtCapacity)
                    Console.WriteLine($"ELEVATOR {i} IS AT CAPACITY <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");
                Console.WriteLine("\n");
            }
            for (int i = 0; i < _service.GetFloors().Count(); i++) {
                Console.WriteLine($"floor {i} requests: " + _service.GetFloors().ElementAt(i).Count());
            }
            _service.ElevateAll();
            Console.WriteLine("=======================================================================");
        }

    }
}
