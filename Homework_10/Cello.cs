namespace Homework_10
{
    class Cello : MusicalInstrument
    {
        public Cello()
            : base(
                "Cello",
                "A large bowed string instrument.",
                "The cello was developed in the 16th century.")
        {
        }

        public override void Sound()
        {
            Console.WriteLine("Sound: Vrooom");
        }
    }
}
