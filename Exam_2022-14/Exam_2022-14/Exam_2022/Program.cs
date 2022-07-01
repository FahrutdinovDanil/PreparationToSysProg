using Bilet14.Units;
using System;

namespace Bilet14
{
    public class Program
    {
        //События сигнализируют системе о том, что произошло определенное действие.И если нам надо отследить эти действия, то как раз мы можем применять события.
        static void Main(string[] args)
        {
            Healer healer = new Healer();
            Soldier soldier = new Soldier();
            Worker worker = new Worker();
            soldier.Notify += DisplayMessage;
            healer.Notify += DisplayMessage;
            worker.Notify += DisplayMessage;
            healer.Heal(soldier);
            soldier.Hit(worker);
            worker.UnitInfo(worker);
            void DisplayMessage(string message) => Console.WriteLine(message);
        }
    }
}
