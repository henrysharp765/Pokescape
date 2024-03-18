namespace PokescapeServer
{
    public class Pokescape
    {
        //1. Find various images for the grid coordinate classes
        //2. Add more types of grid coordinate classes
        //3. Work out the best way to create the grid so that it is both random, but paths also connect
        //
        //
        public static async Task Main(string[] args)
        {

        }
        public static GridCoordinate[][] CreateGrid(int size)
        {
            GridCoordinate[][] grid = new GridCoordinate[size][];
            for (int x = 0; x < size; x++) {
                for (int y = 0; y < size; y++)
                {
                    //handle logic to ensure passages connect up and dont get blocked
                 //   grid[x][y] = new Wallstone()

                }

            }
        }


} }