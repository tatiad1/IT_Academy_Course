
namespace Homework_10
{
    class Trombone : MusicalInstrument
    {
        public Trombone()
            : base(
                "Trombone",
                "A brass wind instrument with a slide.",
                "The trombone appeared in Europe during the 15th century.")
        {
        }

        public override void Sound()
        {
            Console.WriteLine("Sound: Braaam");
        }
    }
}
