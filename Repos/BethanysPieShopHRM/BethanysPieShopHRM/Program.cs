
using BethanysPieShopHRM;

Console.WriteLine("Creating an employee");
Console.WriteLine("---------------------\n");

Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime (1976, 1, 16), 25);

bethany.DisplayEmployeeDetails();

bethany.PerformWork();
bethany.PerformWork();
bethany.PerformWork(5);
bethany.PerformWork();

bethany.firstName = "Mark";
bethany.hourlyRate = 10;

bethany.DisplayEmployeeDetails();
bethany.PerformWork();
bethany.PerformWork(12);
bethany.PerformWork();
bethany.PerformWork();

string fn = bethany.firstName;

double receivedWageBethany = bethany.receiveWage(true);
Console.WriteLine($"Wage paid (message from program): {receivedWageBethany}\n");

Console.WriteLine("Creating an employee");
Console.WriteLine("---------------------\n");

//Either do "Employee george = new Employee()" or "Employee george = new()"
Employee george = new("George", "Jones", "george@snowball.be", new DateTime(1984, 3, 28), 30);

george.DisplayEmployeeDetails();
george.PerformWork();
george.PerformWork();
george.PerformWork(3);
george.PerformWork();
george.PerformWork(8);

var receiveWageGeorge = george.receiveWage(true);

Console.WriteLine("\n");
Console.WriteLine("---------------------");