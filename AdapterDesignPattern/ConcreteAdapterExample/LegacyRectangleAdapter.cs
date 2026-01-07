namespace ConcreteAdapterExample;

public class LegacyRectangleAdapter(LegacyRectangle legacyRectangle) : IRectangle
{
    public long GetArea()
    {
        return legacyRectangle.CalculateArea();
    }

    public long GetPerimeter()
    {
        return legacyRectangle.CalculatePerimeter();
    }

    public void Move(long dx, long dy)
    {
        legacyRectangle.Shift((int)dx, (int)dy); // Maybe we could use Convert.ToInt32 for better safety, but for simplicity, we use a direct cast here.
    }
}
