

using Events.Example2;

Counter counter = new Counter(new Random().Next(10));
counter.ThresholdReached += c_ThresholdReached;

Console.WriteLine("press 'a' key to increase total");

while (Console.ReadKey(true).KeyChar == 'a')
{
    Console.WriteLine("adding one");
    counter.Add(1);
}








    static void c_ThresholdReached(object sender, ThresholdReachedEventArgs e)
    {
        Console.WriteLine("The threshold of {0} was reached at {1}.",e.Threshold,e.TimeReached);
        Environment.Exit(0);
    }
