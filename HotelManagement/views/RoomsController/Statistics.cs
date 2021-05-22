using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement.views.RoomsController
{
    public partial class Statistics : Form
    {
        List<Booking> bookings = new List<Booking>();
        public Statistics(List<Booking> bookings)
        {
            InitializeComponent();
            this.bookings = bookings;
            textBox1.Text += "Camera 1 - Albastru" + Environment.NewLine;
            textBox1.Text += "Camera 2 - Galben" + Environment.NewLine;
            textBox1.Text += "Camera 3 - Rosu" + Environment.NewLine;
            textBox1.Text += "Camera 4 - Mov" + Environment.NewLine;
            textBox1.Text += "Camera 5 - Verde" + Environment.NewLine;
            textBox1.Text += "Camera 6 - Portocaliu";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Font font = new Font(FontFamily.GenericMonospace, 14, FontStyle.Bold);
            Graphics graphics = panel1.CreateGraphics();

            Rectangle rectangle = new Rectangle(100, 100, 350, 250);
            SolidBrush black = new SolidBrush(Color.Black);
            SolidBrush blue = new SolidBrush(Color.Blue);
            SolidBrush green = new SolidBrush(Color.Green);
            SolidBrush red = new SolidBrush(Color.Red);
            SolidBrush yellow = new SolidBrush(Color.Yellow);
            SolidBrush purple = new SolidBrush(Color.Purple);
            SolidBrush orange = new SolidBrush(Color.Orange);

            int b1 = 0;
            int b2 = 0;
            int b3 = 0;
            int b4 = 0;
            int b5 = 0;
            int b6 = 0;

            foreach (Booking b in bookings)
            {
                switch (b.RoomId)
                {
                    case 1:
                        b1++;
                        break;
                    case 2:
                        b2++;
                        break;
                    case 3:
                        b3++;
                        break;
                    case 4:
                        b4++;
                        break;
                    case 5:
                        b5++;
                        break;
                    case 6:
                        b6++;
                        break;
                    default:
                        break;
                }
            }

            int bookingsNumber = bookings.Count;

            float arc1 = (float)360 * b1 / bookingsNumber;
            float arc2 = (float)360 * b2 / bookingsNumber;
            float arc3 = (float)360 * b3 / bookingsNumber;
            float arc4 = (float)360 * b4 / bookingsNumber;
            float arc5 = (float)360 * b5 / bookingsNumber;
            float arc6 = (float)360 * b6 / bookingsNumber;


            graphics.Clear(panel1.BackColor);
            graphics.FillPie(blue, rectangle, 0, arc1);
            graphics.FillPie(yellow, rectangle, arc1, arc2);
            graphics.FillPie(red, rectangle, arc1 + arc2, arc3);
            graphics.FillPie(purple, rectangle, arc1 + arc2 + arc3, arc4);
            graphics.FillPie(green, rectangle, arc1 + arc2 + arc3 + arc4, arc5);
            graphics.FillPie(orange, rectangle, arc1 + arc2 + arc3 + arc4 + arc5, arc6);

            float p1 = (float)100 * b1 / bookingsNumber;
            float p2 = (float)100 * b2 / bookingsNumber;
            float p3 = (float)100 * b3 / bookingsNumber;
            float p4 = (float)100 * b4 / bookingsNumber;
            float p5 = (float)100 * b5 / bookingsNumber;
            float p6 = (float)100 * b6 / bookingsNumber;

            textBox3.Text += "Camera 1 - " + p1 + "%" + Environment.NewLine;
            textBox3.Text += "Camera 2 - " + p2 + "%" + Environment.NewLine;
            textBox3.Text += "Camera 3 - " + p3 + "%" + Environment.NewLine;
            textBox3.Text += "Camera 4 - " + p4 + "%" + Environment.NewLine;
            textBox3.Text += "Camera 5 - " + p5 + "%" + Environment.NewLine;
            textBox3.Text += "Camera 6 - " + p6 + "%" + Environment.NewLine;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
