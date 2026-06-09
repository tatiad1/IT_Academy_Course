namespace Homework_10
{
    class Ukulele : MusicalInstrument
    {
        public Ukulele()
            : base(
                "Ukulele",
                "A small four-string instrument.",
                "The ukulele was developed in Hawaii in the 19th century.")
        {
        }

        public override void Sound()
        {
            Console.WriteLine("Sound: Pling Pling");
        }
    }
}
