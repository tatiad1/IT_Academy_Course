namespace Homework_10
{
    abstract class MusicalInstrument
    {
        protected string Name;
        protected string Description;
        protected string HistoryInfo;

        public MusicalInstrument(string name, string description, string historyInfo)
        {
            Name = name;
            Description = description;
            HistoryInfo = historyInfo;
        }

        public void Show()
        {
            Console.WriteLine($"Instrument: {Name}");
        }

        public virtual void Desc()
        {
            Console.WriteLine($"Description: {Description}");
        }

        public virtual void History()
        {
            Console.WriteLine($"History: {HistoryInfo}");
        }

        public abstract void Sound();
    }
}

