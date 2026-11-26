
interface IShape
{
    IShape Clone(string color);
    void Draw();
}

class Rectangle : IShape
{
    public int Width { get; set; }
    public int Height { get; set; }
    public string Color { get; set; }

    public Rectangle(int width, int height, string color)
    {
        Width = width;
        Height = height;
        Color = color;
    }

    public IShape Clone(string color)
    {
        return new Rectangle(Width, Height, color);
    }

    public void Draw()
    {
        Console.WriteLine(
            $"Прямоугольник: {Width}x{Height}, цвет: {Color}"
        );
    }
}

class Program
{
    static void Main()
    {
        Rectangle original = new Rectangle(100, 50, "Красный");

        Rectangle copy = (Rectangle)original.Clone("Зеленый");

        //copy.Color = "Синий";

        original.Draw();
        
        copy.Draw();

        

    }
}
