interface IButton
{
    void Draw();
}

interface ITextBox
{
    void Draw();
}

class WindowsButton : IButton
{
    public void Draw()
    {
        Console.WriteLine("Кнопка Windows");
    }
}

class WindowsTextBox : ITextBox
{
    public void Draw()
    {
        Console.WriteLine("Текстовое поле Windows");
    }
}

class MacButton : IButton
{
    public void Draw()
    {
        Console.WriteLine("Кнопка macOS");
    }
}

class MacTextBox : ITextBox
{
    public void Draw()
    {
        Console.WriteLine("Текстовое поле macOS");
    }
}

interface IUIFactory
{
    IButton CreateButton();
    ITextBox CreateTextBox();
}

class WindowsFactory : IUIFactory
{
    public IButton CreateButton()
    {
        return new WindowsButton();
    }

    public ITextBox CreateTextBox()
    {
        return new WindowsTextBox();
    }
}

class MacFactory : IUIFactory
{
    public IButton CreateButton()
    {
        return new MacButton();
    }

    public ITextBox CreateTextBox()
    {
        return new MacTextBox();
    }
}

class Program
{
    static void Main()
    {
        IUIFactory factory = new WindowsFactory();

        IButton button = factory.CreateButton();
        ITextBox textBox = factory.CreateTextBox();

        button.Draw();
        textBox.Draw();
    }
}
