public class HotelRoom
{
    private int _roomNumber;
    private int _capacity;
    private decimal _pricePerNight;
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

    public decimal PricePerNight
    {
        get { return _pricePerNight; }
        set { _pricePerNight = value; }
    }

    public bool IsOccupied
    {
        get { return _isOccupied; }
        set { _isOccupied = value; }
    }

    public HotelRoom(int roomNumber, int capacity, decimal pricePerNight, bool isOccupied)
    {
        _roomNumber = roomNumber;
        _capacity = capacity;
        _pricePerNight = pricePerNight;
        _isOccupied = isOccupied;
    }

    public void DisplayRoomInfo()
    {
        Console.WriteLine($"Room Number: {_roomNumber}");
        Console.WriteLine($"Capacity: {_capacity}");
        Console.WriteLine($"Price per Night: {_pricePerNight}");
        Console.WriteLine($"Is Occupied: {_isOccupied}");
    }
}
