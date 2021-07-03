using UnityEngine;
namespace Assets.Scripts.Environment
{
    public class Tile
    {
        public const int DEFAULT_TILE_X = 0;
        public const int DEFAULT_TILE_Y = 0;


        public Vector2Int Location { get; set; }
        public Space Space { get; set; }
        public Tile(int x = DEFAULT_TILE_X, int y = DEFAULT_TILE_Y)
        {
            Location = new Vector2Int(x, y);
        }
    }
}
