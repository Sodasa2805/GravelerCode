namespace GravelerCode;

class Graveler
{
    public static void Main()
    {
        int rolls = 1000000000;
        int timesBeingParalized;
        int maxTimesBeingParalized = 0;

        for (int i = 0; i < rolls; i++)
        {
            timesBeingParalized = 0;

            Random chanceForParalysis = new();

            for (int j = 0; j < 231; j++)
            {
                int rollResult = chanceForParalysis.Next(1, 5);

                if (rollResult == 1)
                {
                    timesBeingParalized++;
                }
            }

            if (timesBeingParalized > maxTimesBeingParalized)
            {
                maxTimesBeingParalized = timesBeingParalized;
            }

            if (timesBeingParalized >= 177)
            {
                Console.WriteLine("Number of Roll Sessions: " + i);
                break;
            }
        }

        Console.WriteLine("The max amount of times graveler was paralized: " + maxTimesBeingParalized);
    }
}
