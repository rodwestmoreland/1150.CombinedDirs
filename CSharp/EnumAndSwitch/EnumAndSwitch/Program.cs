using System;
using System.Collections.Generic;

namespace EnumAndSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Todo> todos = new List<Todo>()
            {
                new Todo { Desc = "Task 1",     Hours = 6,  Status = Status.Completed},
                new Todo { Desc = "Task 2",     Hours = 2,  Status = Status.InProgress},
                new Todo { Desc = "Task 3",     Hours = 8,  Status = Status.NotStarted},
                new Todo { Desc = "Task 4",     Hours = 12, Status = Status.Deleted},
                new Todo { Desc = "Task 5",     Hours = 6,  Status = Status.InProgress},
                new Todo { Desc = "Task 6",     Hours = 2,  Status = Status.NotStarted},
                new Todo { Desc = "Task 7",     Hours = 14, Status = Status.NotStarted},
                new Todo { Desc = "Task 8",     Hours = 8,  Status = Status.Completed},
                new Todo { Desc = "Task 9",     Hours = 8,  Status = Status.InProgress},
                new Todo { Desc = "Task 10",    Hours = 8,  Status = Status.Completed},
                new Todo { Desc = "Task 11",    Hours = 4,  Status = Status.NotStarted},
                new Todo { Desc = "Task 12",    Hours = 10, Status = Status.Completed},
                new Todo { Desc = "Task 13",    Hours = 12, Status = Status.Deleted},
                new Todo { Desc = "Task 14",    Hours = 6,  Status = Status.Completed}
            };

            PrintAssessment(todos);
        }
        private static void PrintAssessment(List<Todo> todos)
        {
            foreach (var todo in todos)
            {
                switch (todo.Status)
                {
                    case Status.NotStarted:
                        Console.WriteLine($"Should be not started: {todo.Desc} {todo.Status}");
                        continue;
                        //break;
                    case Status.InProgress:
                        Console.WriteLine($"Should be in progress: {todo.Desc} {todo.Status}");
                        continue;
                        //break;
                    case Status.OnHold:
                        Console.WriteLine($"Should be on hold: {todo.Desc} {todo.Status}");
                        continue;
                        //break;
                    case Status.Completed:
                        Console.WriteLine($"Should be completed: {todo.Desc} {todo.Status}");
                        continue;
                       
                    default:
                        Console.WriteLine($"Should be deleted: {todo.Desc} {todo.Status}");
                        break;
                }
            }
        }
    }


    class Todo
    {
        public string Desc { get; set; }
        public int Hours { get; set; }
        public Status Status { get; set; }
    }
    enum Status
    {   //these values are associated with numbers (eg NotStarted=0, InProgress=1...)
        NotStarted,
        InProgress,
        OnHold,
        Completed,
        Deleted
    }

}
