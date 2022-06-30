namespace Elephants;

public class Elephant
{

    public string Name;
    public int EarSize;

    public void WhoAmI()
    {
        Console.WriteLine("My name is " + Name);
        Console.WriteLine("My ears are " + EarSize + " inches tall.");
    }
    

    // bar.SpeakTo(foo, "hello")     ->  foo.HearMessage("Hello", bar) 
    // foo.HearMessage("Hello", bar) ->  "Foo heard a message", "Bar said this: Hello"
    public void HearMessage(string message, Elephant whoSaidIt)
    {
        Console.WriteLine(Name + " heard a message");
        Console.WriteLine(whoSaidIt.Name + " said this: " + message);
    }

    public void SpeakTo(Elephant whoToTalkTo, string message)
    {
        whoToTalkTo.HearMessage(message, this);
    }
}