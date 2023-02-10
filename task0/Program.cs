Console.WriteLine("input first number");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input second number");
int numberSecond = Convert.ToInt32(Console.ReadLine());

if(numberSecond * numberSecond == numberOne){
    Console.WriteLine("YES");
}
else
    {
       Console.WriteLine("NO"); 
    }






Console.WriteLine("input number DAY ");
int numDay = Convert.ToInt32(Console.ReadLine());

switch(numDay)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
        Console.WriteLine("Saturday");
        break;
    case 7:
        Console.WriteLine("Sunday");
        break;
    default:
        Console.WriteLine("unknown number");
        break;
}

