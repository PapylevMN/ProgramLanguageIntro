Console.Write("Enter Distanse :");
double distance = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter Friend 1 Speed :");
int friendOneSpeed = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter Friend 2 Speed :");
int friendTwoSpeed = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter Dog Speed :");
int dogSpeed = Convert.ToInt32(Console.ReadLine());

int count = 0; 
int friend = 1;
double time = 0;

while(distance > 1)
{
    if(friend > 0)
    {
    time = distance/(friendOneSpeed+dogSpeed);
    }
    else
    {
    time = distance/(friendTwoSpeed+dogSpeed);
    }
    
    distance = distance-(friendOneSpeed + friendTwoSpeed) * time;
    //Console.WriteLine(distance);
    count++;
    friend = friend *(-1);
}
Console.Write("Dog will shuttle :");
Console.WriteLine(count);
