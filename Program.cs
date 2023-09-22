using System.Dynamic;
using EmmerOpdracht.Abstractions;
using EmmerOpdracht.Implementations;

void shouldBeInvalid<T>(Func<T> creation)
{
    try
    {
        creation();
        throw new Exception("It should have thrown an exception");
    }
    catch (InvalidCapacityException e)
    {
        Console.WriteLine("Threw expected invalid capacity exception");
    }
}

var buckets = new List<Bucket>
{
    new (),
    new (500),
    new (10)
};

buckets[0].Fill(5);
buckets[1].Fill();
buckets[2].Fill(buckets[1]);

foreach (var bucket in buckets) 
{
    Console.WriteLine(bucket);
}


var rainBarrel = new RainBarrel(80);
rainBarrel.Fill(67);
Console.WriteLine(rainBarrel);

var oilBarrel = new OilBarrel();
oilBarrel.Fill(2000);
Console.WriteLine(oilBarrel);

shouldBeInvalid(() => new Bucket(0));
shouldBeInvalid(() => new Bucket(2600));
shouldBeInvalid(() => new RainBarrel(1));
shouldBeInvalid(() => new RainBarrel(150));
