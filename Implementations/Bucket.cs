using EmmerOpdracht.Abstractions;

namespace EmmerOpdracht.Implementations;

public class Bucket : Container
{
    public Bucket() : base(12)
    {
    }
    
    public Bucket(int capacity) : base(capacity)
    {
        if (capacity < 10 || 2500 < capacity)
            throw new InvalidCapacityException();
    }

    /// <param name="bucket">This bucket will be emptied</param>
    public void Fill(Bucket bucket)
    {
        this.Fill(bucket.Capacity);
        bucket.Empty();
    }

    public override string ToString()
    {
        return "Bucket: " + base.ToString();
    }
}