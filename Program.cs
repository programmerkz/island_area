using System;

namespace island_area
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] map = GenerateMap();
            ShowMap(map, false);
            ShowMap(map, true);
        }

        public static void ShowMap(int[,] map, bool show_land_mass = false)
        {
            for (int h = 0; h < map.GetUpperBound(1); h++)
            {
                for (int w = 0; w < map.GetUpperBound(0); w++)
                    if (show_land_mass == false)
                        Console.Write(map[w, h]);
                    else if (map[w, h] > 0)
                        Console.Write("#");
                    else
                        Console.Write(" ");
                Console.WriteLine();
            }
        }

        public static int[,] GenerateMap(int width = 20, int height = 7)
        {
            int[,] map = new int[width, height];
            Random rnd = new Random();

            for (int w = 0; w < map.GetUpperBound(0); w++)
                for (int h = 0; h < map.GetUpperBound(1); h++)
                    map[w, h] = rnd.Next(2);

            return map;
        }
    }
}
