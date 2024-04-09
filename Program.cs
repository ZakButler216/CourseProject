int success = 0;
int failure = 0;
int counter = 0;

while (counter < 5)
{
    Console.WriteLine("Pleae enter an age:");
    int age = int.Parse(Console.ReadLine());

    if (age > 18)
    {
        success++;
        Console.WriteLine(age + ": Entry");
    }
    if (age >= 0 && age <= 18)
    {
        failure++;
        Console.WriteLine(age + ": No Entry");
    }
    counter++;
}

double x = success;
double y = counter;
double z = x / y;
int percent = (int)(z * 100);

Console.WriteLine(success + " Successed");
Console.WriteLine(failure + " Failed");
Console.WriteLine(percent + "% Gained Entry");