Console.WriteLine("Welcome to Employee Wage until it's reached a month");

int RATE_HR = 20;
int MAX_DAYS = 20;
int MAX_HRS = 100;

int empHrs = 0, maxHrs = 0, maxDays = 0;

while (maxHrs <= MAX_HRS && maxDays < MAX_DAYS)
{
    maxDays++;
    
    Random check = new Random();
    int run = check.Next(0, 3);
    switch (run)
    {
        case 0:
            empHrs = 0;
            break;
        case 1:
            empHrs = 8;
            break;
        case 2:
            empHrs = 4;
            break;
    }
    maxHrs += empHrs;
    Console.WriteLine("Day : " + maxDays +"\n "+ "Hours : " + maxHrs);

    int totWage = maxHrs * RATE_HR;
    Console.WriteLine("The total salary is :" + totWage);
}


