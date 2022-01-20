do
{
    int broj;
    do
    {
        Console.WriteLine("Unesite broj");
        broj = int.Parse(Console.ReadLine());
        if (broj <= 1)
        {
            Console.WriteLine("ERROR");
            break;
        }
        do
        {
            do
            {
                if (broj % 2 == 0)
                {
                    broj = broj / 2;
                    Console.WriteLine(broj);
                    break;
                }
                if (broj % 2 == 1)
                {
                    broj = broj * 3 + 1;
                    Console.WriteLine(broj);
                }
            }
            while (true);
        }
        while (broj > 1);
    }
    while (broj > 1);
} while (true); 
while (true);