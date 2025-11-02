using System;

public class Shape
{
    // Base class from previous task
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}

public class Rectangle : Shape
{
    // Private fields
    private int width;
    private int height;

    // Public property Width
    public int Width
    {
        get { return width; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Width must be greater than or equal to 0.");
            width = value;
        }
    }

    // Public property Height
    public int Height
    {
        get { return height; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Height must be greater than or equal to 0.");
            height = value;
        }
    }

    // New Area() method (not override, as per task instructions)
    public new int Area()
    {
        return width * height;
    }

    // Override ToString()
    public override string ToString()
    {
        return $"[Rectangle] {width} / {height}";
    }
}




