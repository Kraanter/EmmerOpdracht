using EmmerOpdracht.Abstractions;

namespace EmmerOpdracht.Implementations;

public class OilBarrel : Container
{
    public OilBarrel() : base(159)
    {
    }

    public override string ToString()
    {
        return "Oil barrel: " + base.ToString();
    }
}