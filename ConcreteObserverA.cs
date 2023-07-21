using ObserverDesignPattern.Interface;

namespace ObserverDesignPattern
{
    public class ConcreteObserverA : IObserver
    {
        public void Update(ISubject subject)
        {
            if (((Subject)subject).State < 3)
                Console.WriteLine("ConcreteObserverA: Reacted to the event.");
        }
    }
}
