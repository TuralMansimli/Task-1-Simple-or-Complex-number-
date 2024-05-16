
//Ədədin sadə və ya mürəkkəb olub olmamasını tapan alqoritm yazılmalıdır.

//Numune 1.

//int num = -54;
//int divider = 0;
//int count = 0;


//while (num >= divider)
//{
//    divider++;

//    if (num % divider == 0)
//    {
//        count++;
//    }

//}
//if (num < 0)
//{
//    Console.WriteLine($"{num} menfidir bu eded ne sadedir nede murekkeb");
//}
//else if (count == 2)
//{
//    Console.WriteLine($"{num} sade ededdir");
//}
//else if (count == 1)
//{
//    Console.WriteLine($"{num} ne sade nede murekkeb ededdir");
//}
//else
//{
//    Console.WriteLine($"{num} murekkeb ededdir");
//}

//Numune 2


int n = 104;
int count = 0;

if (n < 2)
{
    Console.WriteLine("Ne sade ne murekkebdir");
}


else
{
    for (int i = 1; i <= n; i++)
    {
        if(n%i == 0)
        {
            count++;
        }
    }
    if (count == 2)

    {
        
        Console.WriteLine("Sade ededdir");
    }
    else

    {
        
        Console.WriteLine("Murekkeb ededdir");
     
    } 
}
