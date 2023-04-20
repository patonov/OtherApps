namespace ElfWitthWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var firstWord = Console.ReadLine()!.Split(" ").ToArray();
            var secondWord = Console.ReadLine()!.Split(" ").ToArray();
            int result = 0;

            for (int i = 0; i < firstWord.Count(); i++) 
            {
                var letter = firstWord[i];

                for (int j = 0; j < secondWord.Count(); j++)
                {
                    if (secondWord[j] == letter)
                    {
                        secondWord[j] = "_";
                        firstWord[i] = "_";
                    }
                }

            }

            result += firstWord.Count(x => x == "_");
            result  += secondWord.Count(x => x == "_");
            Console.WriteLine(result);
        }
    }
}