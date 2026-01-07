namespace ConcreteAdapterExample;

public class LegacyRectangle(int left, int top, int right, int bottom)
{
    public int CalculateArea()
    {
        int width = right - left;
        int height = bottom - top;
        return width * height;
    }

    public int CalculatePerimeter()
    {
        int width = right - left;
        int height = bottom - top;
        return 2 * (width + height);
    }

    public void Shift(int horizontal, int vertical)
    {
        left += horizontal;
        right += horizontal;
        top += vertical;
        bottom += vertical;
    }
}
