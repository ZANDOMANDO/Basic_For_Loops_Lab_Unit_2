bool continueLoop;
do
{
    Console.WriteLine("Enter a number.");
    int num = int.Parse(Console.ReadLine());
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        sum += i;
    }
    Console.WriteLine(sum);
    Console.WriteLine("Would you like to continue (y/n)?");
    if (Console.ReadLine().Equals("y")) {
        continueLoop = true;
    }
    else
    {
        continueLoop = false;
    }
} while (continueLoop);

Console.WriteLine("Goodbye!");