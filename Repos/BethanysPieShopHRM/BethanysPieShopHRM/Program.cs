
using BethanysPieShopHRM;
using System.Text;

Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime(1976, 1, 16), 25, EmployeeType.Manager);
Employee george = new("George", "Jones", "george@snowball.be", new DateTime(1984, 3, 28), 30, EmployeeType.Research);

Console.WriteLine("Creating an employee");
Console.WriteLine("---------------------\n");

bethany.DisplayEmployeeDetails();

bethany.PerformWork();
bethany.PerformWork();
bethany.PerformWork(5);
bethany.PerformWork();

double receivedWageBethany = bethany.receiveWage(true);
Console.WriteLine($"Wage paid (message from program): {receivedWageBethany}\n");

george.DisplayEmployeeDetails();
george.PerformWork();
george.PerformWork();
george.PerformWork(3);
george.PerformWork();
george.PerformWork(8);

var receiveWageGeorge = george.receiveWage(true);

WorkTask task;
task.description = "Baking delicious pies";
task.hours = 3;
task.PerformWorkTask();