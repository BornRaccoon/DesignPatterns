namespace DesignPatternPractice.Models
{
    interface IStock
    {
        void Notify();
        void Subscribe(Trader trader);
        void Unsubscribe(Trader trader);
    }
}
