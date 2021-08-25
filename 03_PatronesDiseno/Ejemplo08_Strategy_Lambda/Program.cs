using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main() {
        var button1 = new MyButton((x) => x.Sum().ToString(), "Add 'em");
        var button2 = new MyButton((x) => string.Join(" ", x.Select(y => y.ToString()).ToArray()), "Join 'em");

        var numbers = Enumerable.Range(1, 10);
        Console.WriteLine(button1.Submit(numbers));
        Console.WriteLine(button2.Submit(numbers));

        Console.ReadLine();
    }
}

public class MyButton
{
    private readonly Func<IEnumerable<int>, string> submitFunction;
    public string Label { get; private set; }

    public MyButton(Func<IEnumerable<int>, string> submitFunction, string label)
    {
        this.submitFunction = submitFunction;
        Label = label;
    }

    public string Submit(IEnumerable<int> data)
    {
        return submitFunction(data);
    }
}