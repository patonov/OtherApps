namespace BallsInBox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> collorBalls = new Dictionary<string, int>();
            int minBallsToRemove = 0;

            string input = Console.ReadLine()!;

            while (true)
            {
                if (input == "End")
                {
                    break;
                }

                var inputArr = input.Split(": ").ToArray();
                string color = inputArr[0];
                int balls = int.Parse(inputArr[1]);

                if (!collorBalls.ContainsKey(color))
                {
                    collorBalls.Add(color, 0);
                }
                else
                {
                    collorBalls[color] += balls;
                }

                input = Console.ReadLine()!;
            }

            string colorToFind = collorBalls.Max(b => b.Key)!;

            int interim = 0;

            foreach (var color in collorBalls)
            {
                if (color.Key == colorToFind)
                {
                    continue;
                }

                interim += color.Value;
            }

            Console.WriteLine(interim);


        }
    }
}