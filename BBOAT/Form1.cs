using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BBOAT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Speedboat speedboat = new Speedboat("Speedsee 1000", 70);
        Fishingboat fishingboat = new Fishingboat("TRAL", 25);
        Sailingboat sailingboat = new Sailingboat("Windcutter 900", 15);

        int oldpoint = 100;

        private async void button1_Click(object sender, EventArgs e)
        {
            string boatName = speedboat.Name;
            int boatSpeed = speedboat.Speed;

            label1.Text = $"������ �����: {boatName}";
            label2.Text = $"����������� ��������: : {boatSpeed} �����";

            int maxpoint = oldpoint + speedboat.Speed * 2;

            while (pictureBox2.Left != maxpoint)
            {
                if (pictureBox2.Left > maxpoint)
                {
                    pictureBox2.Left--; 
                }
                else
                {
                    pictureBox2.Left += 2; 
                }

                await Task.Delay(50); 
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            string boatName = fishingboat.Name;
            int boatSpeed = fishingboat.Speed;

            
            label1.Text = $"������ �����: {boatName}";
            label2.Text = $"����������� ��������: {boatSpeed} �����";

            int maxpoint = oldpoint + fishingboat.Speed * 2;

            while (pictureBox2.Left != maxpoint)
            {
                if (pictureBox2.Left > maxpoint)
                {
                    pictureBox2.Left--; 
                }
                else
                {
                    pictureBox2.Left++; 
                }

                await Task.Delay(50); 
            }
        }


        private async void button3_Click(object sender, EventArgs e)
        {
            string boatName = sailingboat.Name;
            int boatSpeed = sailingboat.Speed;

            label1.Text = $"������ �����: {boatName}";
            label2.Text = $"����������� ��������: {boatSpeed} �����";

            int maxpoint = oldpoint + sailingboat.Speed * 2;

            while (pictureBox2.Left != maxpoint)
            {
                if (pictureBox2.Left > maxpoint)
                {
                    pictureBox2.Left--; 
                }
                else
                {
                    pictureBox2.Left++; 
                }

                await Task.Delay(50); 
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
