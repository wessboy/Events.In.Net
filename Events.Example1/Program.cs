
using Events.Example1;

Counter counter = new Counter(new Random().Next(10));
counter.ThresholdReached += c_thresholdReached;

Console.WriteLine("press 'a' key to increase total");

while (Console.ReadKey(true).KeyChar == 'a')
{
    Console.WriteLine("adding one");
    counter.Add(1);
}

static void c_thresholdReached(object sender, EventArgs e)
{
    Console.WriteLine("The threshold was reached.");
    Environment.Exit(0);
}
