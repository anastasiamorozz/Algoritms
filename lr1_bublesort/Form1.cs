using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace lr1_bublesort
{
    public partial class Form1 : Form
    {

        List<HotelRoom> rooms = new List<HotelRoom>()
            ;

        public void ClearTextBox()
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Clear();
                }
            }
        }

        public void SaveObjectToFile()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<HotelRoom>));
                using (TextWriter writer = new StreamWriter("rooms.xml"))
                {
                    serializer.Serialize(writer, rooms);
                }
            }
            catch (Exception ex)
            {
            }
        }

        public void DeserializeObjectFromFile()
        {
            rooms = null;
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<HotelRoom>));
                using (TextReader reader = new StreamReader("rooms.xml"))
                {
                    rooms = (List<HotelRoom>)serializer.Deserialize(reader);
                }
            }
            catch (Exception ex)
            {
            }

        }

        public void DisplayDataGridView()
        {
            dataGridView1.Rows.Clear();

            foreach (HotelRoom room in rooms)
            {
                dataGridView1.Rows.Add(room.RoomNumber, room.Capacity, room.PricePerNight, room.IsOccupied);
            }
        }

        private void Swap(List<HotelRoom> rooms, int i, int j)
        {
            HotelRoom temp = rooms[i];
            rooms[i] = rooms[j];
            rooms[j] = temp;
        }

        private void BubbleSortByCapacity(List<HotelRoom> rooms)
        {
            int n = rooms.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (rooms[j].Capacity > rooms[j + 1].Capacity)
                    {
                        Swap(rooms, j, j + 1);
                    }
                }
            }
        }

        private void BubbleSortByRoomNumber(List<HotelRoom> rooms)
        {
            int n = rooms.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (rooms[j].RoomNumber > rooms[j + 1].RoomNumber)
                    {
                        Swap(rooms, j, j + 1);
                    }
                }
            }
        }

        private void BubbleSortByPricePerNight(List<HotelRoom> rooms)
        {
            int n = rooms.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (rooms[j].PricePerNight > rooms[j + 1].PricePerNight)
                    {
                        Swap(rooms, j, j + 1);
                    }
                }
            }
        }


        public void ShakerSortByRoomNumber(List<HotelRoom> rooms)
        {
            int left = 0;
            int right = rooms.Count - 1;

            while (left < right)
            {
                for (int i = left; i < right; i++)
                {
                    if (rooms[i].RoomNumber > rooms[i + 1].RoomNumber)
                    {
                        Swap(rooms, i, i + 1);
                    }
                }

                right--;

                for (int i = right; i > left; i--)
                {
                    if (rooms[i].RoomNumber < rooms[i - 1].RoomNumber)
                    {
                        Swap(rooms, i, i - 1);
                    }
                }

                left++;
            }
        }

        public void ShakerSortByCapacity(List<HotelRoom> rooms)
        {
            int left = 0;
            int right = rooms.Count - 1;

            while (left < right)
            {
                for (int i = left; i < right; i++)
                {
                    if (rooms[i].Capacity > rooms[i + 1].Capacity)
                    {
                        Swap(rooms, i, i + 1);
                    }
                }

                right--;

                for (int i = right; i > left; i--)
                {
                    if (rooms[i].Capacity < rooms[i - 1].Capacity)
                    {
                        Swap(rooms, i, i - 1);
                    }
                }

                left++;
            }
        }

        public void ShakerSortByPricePerNight(List<HotelRoom> rooms)
        {
            int left = 0;
            int right = rooms.Count - 1;

            while (left < right)
            {
                for (int i = left; i < right; i++)
                {
                    if (rooms[i].PricePerNight > rooms[i + 1].PricePerNight)
                    {
                        Swap(rooms, i, i + 1);
                    }
                }

                right--;

                for (int i = right; i > left; i--)
                {
                    if (rooms[i].PricePerNight < rooms[i - 1].PricePerNight)
                    {
                        Swap(rooms, i, i - 1);
                    }
                }

                left++;
            }
        }

        public void SelectionSortByRoomNumber(List<HotelRoom> rooms)
        {

            for (int i = 0; i < rooms.Count; i++)
            {
                int minIndex = i;

                for (int j = i; j < rooms.Count; j++)
                {
                    if (rooms[j].RoomNumber < rooms[minIndex].RoomNumber)
                    {
                        minIndex = j;
                    }
                }

                if (minIndex != i)
                {
                    Swap(rooms, i, minIndex);
                }
            }
        }

        public void SelectionSortByCapacity(List<HotelRoom> rooms)
        {

            for (int i = 0; i < rooms.Count; i++)
            {
                int minIndex = i;

                for (int j = i; j < rooms.Count; j++)
                {
                    if (rooms[j].Capacity < rooms[minIndex].Capacity)
                    {
                        minIndex = j;
                    }
                }

                if (minIndex != i)
                {
                    Swap(rooms, i, minIndex);
                }
            }
        }

        public void SelectionSortByPricePerNight(List<HotelRoom> rooms)
        {

            for (int i = 0; i < rooms.Count; i++)
            {
                int minIndex = i;

                for (int j = i; j < rooms.Count; j++)
                {
                    if (rooms[j].PricePerNight < rooms[minIndex].PricePerNight)
                    {
                        minIndex = j;
                    }
                }

                if (minIndex != i)
                {
                    Swap(rooms, i, minIndex);
                }
            }
        }

        public static void InsertionSortByRoomNumber(List<HotelRoom> rooms)
        {
            for (int i = 1; i < rooms.Count; i++)
            {
                HotelRoom temp = rooms[i];
                int j = i - 1;

                while (j >= 0 && rooms[j].RoomNumber > temp.RoomNumber)
                {
                    rooms[j + 1] = rooms[j];
                    j--;
                }

                rooms[j + 1] = temp;
            }
        }

        public static void InsertionSortByCapacity(List<HotelRoom> rooms)
        {
            for (int i = 1; i < rooms.Count; i++)
            {
                HotelRoom temp = rooms[i];
                int j = i - 1;

                while (j >= 0 && rooms[j].Capacity > temp.Capacity)
                {
                    rooms[j + 1] = rooms[j];
                    j--;
                }

                rooms[j + 1] = temp;
            }
        }

        public static void InsertionSortByPricePerNight(List<HotelRoom> rooms)
        {
            for (int i = 1; i < rooms.Count; i++)
            {
                HotelRoom temp = rooms[i];
                int j = i - 1;

                while (j >= 0 && rooms[j].PricePerNight > temp.PricePerNight)
                {
                    rooms[j + 1] = rooms[j];
                    j--;
                }

                rooms[j + 1] = temp;
            }
        }


        public Form1()
        {
            InitializeComponent();
            
            dataGridView1.Columns.Add("RoomNumber", "Íîìåð ê³ìíàòè");
            dataGridView1.Columns.Add("Capacity", "Ì³ñöÿ");
            dataGridView1.Columns.Add("PricePerNight", "Ö³íà");
            dataGridView1.Columns.Add("IsOccupied", "Çàéíÿò³ñòü");

            DeserializeObjectFromFile();
            
            DisplayDataGridView();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        Boolean status = false;

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                if (radioButton2.Checked) { status = true; }
                HotelRoom newRoom = new HotelRoom(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToDouble(textBox3.Text), status);
                rooms.Add(newRoom);
                SaveObjectToFile();
                dataGridView1.Rows.Add(newRoom.RoomNumber, newRoom.Capacity, newRoom.PricePerNight, newRoom.IsOccupied);
                ClearTextBox();
            }
           
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void çàÊ³ëüê³ñòþÌ³ñöüToolStripMenuItem_Click(object sender, EventArgs e)
        {
                BubbleSortByCapacity(rooms);
                DisplayDataGridView();
        }

        private void çàÍîìåðîìÊ³ìíàòèToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BubbleSortByRoomNumber(rooms);
            DisplayDataGridView();
        }

        private void çàÂàðò³ñòþToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BubbleSortByPricePerNight(rooms);
            DisplayDataGridView();
        }

        private void ñîðòóâàííÿÁóëüáàøêîþToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void çàÖ³íîþToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShakerSortByPricePerNight(rooms);
            DisplayDataGridView();
        }

        private void çàÍîðìåðîìÊ³ìíàòèToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShakerSortByRoomNumber(rooms);
            DisplayDataGridView();
        }

        private void çàÌ³ñöÿìèToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShakerSortByCapacity(rooms);
            DisplayDataGridView();
        }

        private void çàToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectionSortByRoomNumber(rooms);
            DisplayDataGridView();
        }

        private void çàÖ³íîþToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SelectionSortByPricePerNight(rooms);
            DisplayDataGridView();
        }

        private void ñîðòóâàííÿÌ³íÅëåìåíòîìToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void çàÌ³ñöÿìèToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SelectionSortByCapacity(rooms);
            DisplayDataGridView();
        }

        private void ä³¿ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void çàÖ³íîþToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            InsertionSortByPricePerNight(rooms);
            DisplayDataGridView();
        }

        private void çàÍîìåðîìÊ³ìíàòèToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            InsertionSortByRoomNumber(rooms);
            DisplayDataGridView();
        }

        private void çàÌ³ñöÿìèToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            InsertionSortByCapacity(rooms);
            DisplayDataGridView();
        }
    }
}