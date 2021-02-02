using System;

namespace Task02
{
    class PlayStartedEventArgs : EventArgs
    {
        public int Sound = 0;
    }
    class Bandmaster
    {
        Random rnd = new Random();
        public event EventHandler<PlayStartedEventArgs> Notify;
        public void StartPlay(int n)
        {
            Notify?.Invoke(this, new PlayStartedEventArgs() { Sound = rnd.Next(2,5) });
        }
    }
    abstract class OrchestraPlayer
    {
        public OrchestraPlayer(string name)
        {
            Name = name;
        }
        public string Name { get; protected set; }
        public abstract void PlayIsStartedEvent(object sender, PlayStartedEventArgs e);
    }
    class Violinist : OrchestraPlayer
    {
        public Violinist(string name) : base(name) { }
        public override void PlayIsStartedEvent(object sender, PlayStartedEventArgs e)
        {
            Console.WriteLine($"Violinist {Name} plays composion #{e.Sound}: La-la!");
        }
    }
    class Hornist : OrchestraPlayer
    {
        public Hornist(string name) : base(name) { }
        public override void PlayIsStartedEvent(object sender, PlayStartedEventArgs e)
        {
            Console.WriteLine($"Hornist {Name} starts playing composion #{e.Sound}: Du-du!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random;
            OrchestraPlayer[] orchArray = new OrchestraPlayer[10];
            Bandmaster band = new Bandmaster();
            for (int i = 0; i < orchArray.Length; i++) {
                if (rnd.Next(0, 1) == 0) orchArray[i] = new Violinist(rnd.Next(0,10000).ToString());
                else orchArray[i] = new Hornist(rnd.Next(0, 10000).ToString());
                band.Notify += orchArray[i].PlayIsStartedEvent;
            }
            band.StartPlay();
        }
    }
}
