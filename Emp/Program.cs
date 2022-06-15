//Random wage = new Random();
//int check = wage.Next(0, 4);

//switch (check)
//{
//    case 0:
//        Console.WriteLine("absent");
//        break;
//    case 1:
//        Console.WriteLine("Present");
//        break;
//    case 2:
//        Console.WriteLine("PartTime");
//        break;
//    default:
//        Console.WriteLine("Error in values");
//        break;
//}


int EMP_SALARY = 50;
int empWrkHrs = 0;

Random num = new Random();
int ran = num.Next(0, 4);

switch (ran)
{
    case 0:
        Console.WriteLine("absent");
        empWrkHrs = 0;
        break;
    case 1:
        Console.WriteLine("Present");
        empWrkHrs = 16;
        break;
    case 2:
        Console.WriteLine("PartTime");
        empWrkHrs = 8;
        break;
    default:
        Console.WriteLine("Error in values");
        break;
}
int empWage = (empWrkHrs * EMP_SALARY);
Console.WriteLine("The total salary is :" + empWage);