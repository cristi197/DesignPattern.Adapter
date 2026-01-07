// client - Game Engine

using ConcreteAdapterExample;

void CenterRectangle(IRectangle rectangle)
{
    // Move the rectangle to the center
}

LegacyRectangle legacyRectangle = new(
    left: 0,
    top: 0,
    right: 100,
    bottom: 50);

IRectangle rectangle = new LegacyRectangleAdapter(legacyRectangle);
CenterRectangle(rectangle);