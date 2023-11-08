namespace VirtuelBookSystem
{
    internal class Start
    {
        internal void StartProgram()
        {
            List<Media> mediaList = new List<Media>();

            Bok b1 = new Bok("Ondskan", "Jan Guillou", "1234 5678 9");
            Bok b2 = new Bok("Programmering 1", "Sture Nilsson", "1234 8888 9");
            Ebok eb1 = new Ebok("Applying UML and Patterns","Craig Larman","0-13-148906-2");


            mediaList.Add(b1);
            mediaList.Add(b2);
            mediaList.Add(eb1);

            foreach (var item in mediaList)
            {
                item.VisaInfo();
                Console.WriteLine();
            }
        }
    }
}
