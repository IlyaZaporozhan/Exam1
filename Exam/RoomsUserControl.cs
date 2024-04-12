using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Exam.ModelEF;

namespace Exam
{
   
    public partial class RoomsUserControl : UserControl
    {
        private Rooms _rooms;
        private RoomType _roomType;
        public RoomsUserControl(Rooms rooms, RoomType roomType)
        {
            InitializeComponent();
            _rooms = rooms;
            _roomType = roomType;
            
            Fill(rooms);

            foreach(Control item in Controls)
            {
                item.Click += (s, e) => RoomsUserControl_Click(s, e);
            }
        }
        public void Fill (Rooms rooms)
        {
            var model1 = new Model1();
            NumberRoom.Text = rooms.NuberRoom.ToString();
            
        }

        private void RoomsUserControl_Click(object sender, EventArgs e)
        {
            
        }

        private void RoomsUserControl_Load(object sender, EventArgs e)
        {
            NumberRoom.Text = _rooms.NuberRoom.ToString();
            Places.Text = _rooms.NumberOfPlaces.ToString();
            NumberOfRoom.Text = _rooms.NumberOfRooms.ToString();
            TypeRoom.Text = _roomType.Name.ToString();
            Floor.Text = _rooms.Floor.ToString();
            Cost.Text = _rooms.Cost.ToString();
        }
    }
    
}
