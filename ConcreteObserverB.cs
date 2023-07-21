using ObserverDesignPattern.Interface;

namespace ObserverDesignPattern
{
    public class ConcreteObserverB : IObserver
    {
        public void Update(ISubject subject)
        {
            if (((Subject)subject).State == 0 || ((Subject)subject).State >= 2)
                Console.WriteLine("ConcreteObserverB: Reacted to the event.");
        }
    }
}
