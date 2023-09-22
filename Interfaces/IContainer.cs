namespace EmmerOpdracht;

public interface IContainer
{
    public int Capacity { get; }
    public int Size { get; set; }

    public void Fill(int hoeveelheid);
    public void Empty(int units);
}