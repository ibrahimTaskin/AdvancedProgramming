MyDelegateHandler myDelegate = (string name) => Greeting(name);
myDelegate("Meryem"); // Invoke ederiz.

MyEventPublisher m = new();
m.MyEvent += RaiseText;
m.RaiseEvent(); // MyEvent tetiklenir.


GreetingHandler greetingHandler = () => Console.WriteLine("Welcome 1");
greetingHandler += () => Console.WriteLine("Welcome 2");
greetingHandler += () => Console.WriteLine("Welcome 3");
greetingHandler += () => Console.WriteLine("Welcome 4");
greetingHandler += () => Console.WriteLine("Welcome 5");
greetingHandler(); // Invoke ederiz.

Console.ReadLine();

void Greeting(string name) => Console.WriteLine($"Hello " + name);
void RaiseText() => Console.WriteLine("Text raised!");

public delegate void MyDelegateHandler(string name);
public delegate void GreetingHandler();



class MyEventPublisher
{
    public delegate void XHandler();
    public event XHandler MyEvent;
    public void RaiseEvent()
    {
        MyEvent?.Invoke();
    }
}
