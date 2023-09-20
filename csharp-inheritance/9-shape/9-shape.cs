using System;

///<summary>
/// This is a class called Shape
///</summary>
public class Shape
{
    /// <summary>
    /// This computes the area of a Shape
    /// </summary>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}

/// <summary>
/// This is a class called Rectangle that inherits from Shape
/// </summary>
public class Rectangle : Shape
{
    private int width;
    private int height;

    /// <summary>
    /// This is a getter/setter for a Rectangle's width
    /// </summary>
    public int Width
    {
        get
        {
            return width;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Width must be greater than or equal to 0");
            }

            width = value;
        }
    }

    /// <summary>
    /// This is a getter/setter for a Rectangle's height
    /// </summary>
    public int Height
    {
        get
        {
            return height;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Height must be greater than or equal to 0");
            }

            height = value;
        }
    }

    /// <summary>
    /// This computes the area of a Rectangle
    /// </summary>
    public new int Area()
    {
        return Width * Height;
    }

    /// <summary>
    /// The console returns a string representation of a Shape
    /// </summary>
    public override string ToString()
    {
        return $"[{this.GetType().Name}] {Width} / {Height}";
    }
}

/// <summary>
/// This is a class called Square that inherits from Rectangle
/// </summary>
public class Square : Rectangle
{
    private int size;

    /// <summary>
    /// This is a getter/setter for a Square's size
    /// </summary>
    public int Size
    {
        get { return size; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Size must be greater than or equal to 0");
            
            size = value;
            Height = value;
            Width = value;
        }
    }
}