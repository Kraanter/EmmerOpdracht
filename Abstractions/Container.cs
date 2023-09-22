namespace EmmerOpdracht.Abstractions;

public abstract class Container : IContainer
{
    private int _size;
    private int _capacity;
    
    public int Capacity
    {
        get => _capacity;
        private set
        {
            if (value < 1)
                throw new InvalidCapacityException();
                    
            _capacity = value;
        }
    }

    public int Size
    {
        get => _size;
        set
        {
            _size = Math.Min(Math.Max(value, 0), Capacity);
        }
    }

    public Container(int capacity)
    {
        Capacity = capacity;
        Size = 0;
    }

    public void Fill()
    {
        Size = Capacity;
    }
    
    public void Fill(int units)
    {
        Size += units;
    }
    
    public void Empty()
    {
        Size = 0;
    }

    public void Empty(int units)
    {
        Size -= units;
    }

    public override string ToString()
    {
        return $"Filled: {Size}/{Capacity}";
    }
}

public class InvalidCapacityException : Exception
{
}

