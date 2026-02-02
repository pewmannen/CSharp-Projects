

int amount = 1234;
int months = 12;

CalculateYearlyWage(amount, months);

static void CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked)
{
    Console.WriteLine($"Yearly wage: {monthlyWage * numberOfMonthsWorked}");
}