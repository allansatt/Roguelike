using System.Collections.ObjectModel;

namespace Assets.Scripts.Environment
{
    public class Map
    {
        public int MaxFeatures { get; private set; }
        public int MaxRooms { get; private set; }
        public int MaxRoomHeight { get; private set; }
        public int MaxRoomWidth { get; private set; }

        public const int DEFAULT_MAX_FEATURES = 10;

        public const int DEFAULT_MAX_ROOMS = 10;

        public const int DEFAULT_MAX_ROOM_HEIGHT = 10;

        public const int DEFAULT_MAX_ROOM_WIDTH = 10;

        public Tile[][] Layout { get; set; }
        public Collection<Space> Spaces { get; set; }
        public Map(int maxFeatures = DEFAULT_MAX_FEATURES, int maxRooms = DEFAULT_MAX_ROOMS, int maxRoomHeight = DEFAULT_MAX_ROOM_HEIGHT, int maxRoomWidth = DEFAULT_MAX_ROOM_WIDTH)
        {
            MaxFeatures = maxFeatures;
            MaxRooms = maxRooms;
            MaxRoomHeight = maxRoomHeight;
            MaxRoomWidth = maxRoomWidth;
        }

        private Room getFirstRoom()
        {
            return new Room;
        }
    }
}