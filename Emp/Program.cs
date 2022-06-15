Console.WriteLine("Calculate Daily Employee Wage");




int present = 1;

Random num = new Random();
int ran = num.Next(0, 2);

if (ran == present)
{
    Console.WriteLine("Is Present");
    int empWrkHrs = 8;
    int empSalary = 50;
    int empWage = (empWrkHrs * empSalary);
    Console.WriteLine("The total salary is :" + empWage);

}
else
{
    Console.WriteLine("Is Absent");
    int empWrkHrs = 0;
    int empSalary = 50;
    int empWage = (empWrkHrs * empSalary);
    Console.WriteLine("The total salary is :" + empWage);

}


