class Wage
{
    static void main(string[] args)
    {

        int EMP_PRESENT = 1;
        int EMP_SALARY = 50;

        Random num = new Random();
        int ran = num.Next(0, 2);

        int empWrkHrs = 0;

        if (ran == EMP_PRESENT)
        {
            Console.WriteLine("Is Present");
            empWrkHrs = 8;


        }
        else
        {
            Console.WriteLine("Is Absent");
            empWrkHrs = 0;


        }

        int empWage = (empWrkHrs * EMP_SALARY);
        Console.WriteLine("The total salary is :" + empWage);
    }
}