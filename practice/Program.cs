/* int x = 4321;
int x1 = x%10; //1
x = x/10; //432
int x2 = x%10; //2
x=x/10; //43
int x3 = x%10; //3
int x4 =x/10; //4
int sum = x1 + x2 + x3 +x4; 
Console.WriteLine(sum); */

int x = 4321;
int x1;
int sum = 0;

while (x > 0)
{
    x1 = x%10;
    x/=10;
    sum = sum + x1;
    Console.WriteLine(x1);

}
Console.WriteLine("SUM: " + sum);



