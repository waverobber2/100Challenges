namespace Exercise_10;

public class WeekSchedule
{
    private readonly Dictionary<DayOfWeek, string?> _plans = new();

    //your code goes here
}

/*
Implement a weekly schedule with multiple custom indexers (⭐⭐)
Exercise description:

Implement the WeekSchedule class that allows storing and retrieving plans 
for days of the week using two custom indexers.

The first indexer accepts a DayOfWeek enum value.

The second indexer accepts a string and attempts to parse it into a DayOfWeek. 
If parsing fails, it should throw an ArgumentException.

Both should use the underlying _plans Dictionary.

The string-based indexer should work regardless of casing (e.g. "monday" or 
"MONDAY" are both valid).

If no note is stored for a given day, the indexer should return null.

What you'll practice:
Creating a custom indexer with an enum as the index type
Overloading an indexer to also accept a string
Parsing strings into enums with Enum.TryParse
Throwing exceptions for invalid input
Working with Dictionaries

Example usage:

var schedule = new WeekSchedule();
schedule[DayOfWeek.Monday] = "Gym";
schedule["Friday"] = "Dinner with friends";
 
var mondayNote = schedule["monday"];   // => "Gym" (case-insensitive)
var fridayNote = schedule[DayOfWeek.Friday]; // => "Dinner with friends"
var tuesdayNote = schedule["Tuesday"]; // => null
 
// schedule["Funday"]; // => throws ArgumentException

 
/////////////////////////////////////    EXAMPLE    //////////////////////////////////////////// 
 class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Department { get; set; } = string.Empty;

        public override string ToString()
        {
            return $"{Id,-5} {Name,-10} {Department}";
        }
    }

    class EmployeeRepository
    {
        private readonly Dictionary<int, Employee> _employees = new();

        // Indexer #1 - Access by Employee ID
        public Employee? this[int id]
        {
            get
            {
                _employees.TryGetValue(id, out Employee? employee);
                return employee;
            }
            set
            {
                if (value != null)
                {
                    _employees[id] = value;
                }
            }
        }

        // Indexer #2 - Access by Employee Name
        public Employee? this[string name]
        {
            get
            {
                return _employees.Values
                    .FirstOrDefault(e =>
                        e.Name.Equals(name,
                            StringComparison.OrdinalIgnoreCase));
            }
        }

        public void DisplayAll()
        {
            foreach (Employee employee in _employees.Values)
            {
                Console.WriteLine(employee);
            }
        }
    }

    class Program
    {
        static void Main()
        {
            EmployeeRepository employees = new();

            // Using indexer #1 to add data
            employees[100] = new Employee
            {
                Id = 100,
                Name = "Randy",
                Department = "Finance"
            };

            employees[200] = new Employee
            {
                Id = 200,
                Name = "Lisa",
                Department = "IT"
            };

            employees[300] = new Employee
            {
                Id = 300,
                Name = "Mike",
                Department = "Sales"
            };

            Console.WriteLine("Lookup by ID:");
            Console.WriteLine(employees[200]);

            Console.WriteLine();

            Console.WriteLine("Lookup by Name:");
            Console.WriteLine(employees["Mike"]);

            Console.WriteLine();

            Console.WriteLine("All Employees:");
            employees.DisplayAll();
        }
    }
*/