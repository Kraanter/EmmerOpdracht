namespace EmmerOpdracht;

public interface IContainer
{
    // The maximum size of a container
    public int Capacity { get; }
    // The amount the container is filled
    public int Size { get; set; }

    public void Fill(int units);
    public void Empty(int units);
}