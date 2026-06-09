namespace Homework_10
{
    class Violin : MusicalInstrument
    {
        public Violin()
            : base(
                "Violin",
                "A bowed string instrument.",
                "The violin originated in Italy during the 16th century.")
        {
        }

        public override void Sound()
        {
            Console.WriteLine("Sound: Screech Screech");
        }
    }
}
