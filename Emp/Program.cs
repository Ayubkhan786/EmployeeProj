

int EMP_PRESENT = 1;
int EMP_PART = 2;
int EMP_SALARY = 50;

Random num = new Random();
int ran = num.Next(0, 3);

int empWrkHrs = 0;

if (ran == EMP_PRESENT)
{
    Console.WriteLine("Is Present");
    empWrkHrs = 16;


}
else if (ran == EMP_PART)
{
    Console.WriteLine("Is Part-Time");
    empWrkHrs = 8;


}
else
{
    Console.WriteLine("Is Absent");
    empWrkHrs = 0;


}

int empWage = (empWrkHrs * EMP_SALARY);
Console.WriteLine("The total salary is :" + empWage);