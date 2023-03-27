namespace lr1_bublesort
{
    [Serializable]
    public class HotelRoom
    {
        private int _roomNumber;
        private int _capacity;
        private double _pricePerNight;
        private bool _isOccupied;

        public int RoomNumber
        {
            get { return _roomNumber; }
            set { _roomNumber = value; }
        }

        public int Capacity
        {
            get { return _capacity; }
            set { _capacity = value; }
        }

        public double PricePerNight
        {
            get { return _pricePerNight; }
            set { _pricePerNight = value; }
        }

        public bool IsOccupied
        {
            get { return _isOccupied; }
            set { _isOccupied = value; }
        }

        public HotelRoom() { }

        public HotelRoom(int roomNumber, int capacity, double pricePerNight, bool isOccupied)
        {
            _roomNumber = roomNumber;
            _capacity = capacity;
            _pricePerNight = pricePerNight;
            _isOccupied = isOccupied;
        }

    }

}