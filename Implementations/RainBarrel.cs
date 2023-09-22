using EmmerOpdracht.Abstractions;

namespace EmmerOpdracht.Implementations;

public class RainBarrel : Container
{
    private static int[] ALLOWED_CAPACITY = { 80, 100, 120 };
    
    /// <param name="capacity">The capacity must be 80, 100 or 120</param>
    public RainBarrel(int capacity) : base(capacity)
    {
        if (!ALLOWED_CAPACITY.Contains(capacity))
            throw new InvalidCapacityException();
    }

    public override string ToString()
    {
        return "Rain barrel: " + base.ToString();
    }
}