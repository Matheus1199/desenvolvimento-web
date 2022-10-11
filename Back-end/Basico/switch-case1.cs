using System;

public enum color { Red, Green, Blue }

public class Example
{
    public static void Main(String[] args)
    {
        color c = (color)(new Randow()).Next(0, 3);
        switch (c)
        {
            case color.Red:
                console.WriteLine("The color is red");
                break;
            case color.Green:
                console.WriteLine("The color is green");
                break;
            case color.Blue:
                console.WriteLine("The color is blue");
                break;
            default:
                console.WriteLine("The color is unknown.");
                break;
        }
    }
}