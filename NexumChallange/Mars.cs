using NexumChallange.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NexumChallange
{
    public partial class Mars : Form
    {
        BindingList<Traveler> travelerList;
        BindingList<Traveler> travelerResultList;
        char[] ConfirmVariables;
        char[] ConfirmDirection;
        public Mars()
        {
            InitializeComponent();

            travelerList = new BindingList<Traveler>();
            travelerResultList = new BindingList<Traveler>();
            ConfirmDirection = new char[] { 'N', 'E', 'S', 'W' };
            ConfirmVariables = new char[] { 'L', 'R', 'M' };
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var locationVariables = txtLocation.Text.Split(' ');
                var infoVariables = txtInfo.Text;
                char direction = char.Parse(locationVariables[2]);

                if (!ConfirmDirection.Contains(direction))
                {
                    MessageBox.Show("Yön bilgisi hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (infoVariables.Any(a => !ConfirmVariables.Contains(a)))
                {
                    MessageBox.Show("Katar bilgisi hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var newTraveler = new Traveler
                {
                    Tag = !string.IsNullOrEmpty(txtTag.Text) ? txtTag.Text : "ExampleTraveler",
                    X = int.Parse(locationVariables[0]),
                    Y = int.Parse(locationVariables[1]),
                    Direction = direction,
                    InfoVariables = infoVariables
                };

                travelerList.Add(newTraveler);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata!");
            }
            
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            lstTravelers.DataSource = travelerList;
            lstTravelers.DisplayMember = "Tag";

            lstResultTravelers.DataSource = travelerResultList;
            lstResultTravelers.DisplayMember = "Tag";
        }

        private void lstTravelers_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedTraveler = lstTravelers.SelectedItem as Traveler;

            lblTag.Text = selectedTraveler.Tag;
            lblX.Text = selectedTraveler.X.ToString();
            lblY.Text = selectedTraveler.Y.ToString();
            lblDirection.Text = selectedTraveler.Direction.ToString();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var traveler in travelerList)
                {
                    foreach (var info in traveler.InfoVariables)
                    {
                        ChangeDirection(traveler, info);
                    }

                    travelerResultList.Add(traveler);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata!");
            }
        }

        private void lstResultTravelers_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedTraveler = lstResultTravelers.SelectedItem as Traveler;

            lblTagResult.Text = selectedTraveler.Tag;
            lblXResult.Text = selectedTraveler.X.ToString();
            lblYResult.Text = selectedTraveler.Y.ToString();
            lblDirectionResult.Text = selectedTraveler.Direction.ToString();
        }

        #region Custom
        void ChangeDirection(Traveler traveler, char info)
        {
            var directionIndex = Array.IndexOf(ConfirmDirection, traveler.Direction);
            switch (info)
            {
                case 'L':
                    {
                        traveler.Direction = (directionIndex - 1) < 0 ? ConfirmDirection[ConfirmDirection.Length - 1] : ConfirmDirection[directionIndex - 1];
                        break;
                    }

                case 'R':
                    {
                        traveler.Direction = (directionIndex + 1) >= ConfirmDirection.Length ? ConfirmDirection[0] : ConfirmDirection[directionIndex + 1];
                        break;
                    }

                case 'M':
                    {
                        Move(traveler);
                        break;
                    }
            }
        }

        void Move(Traveler traveler)
        {
            var sizeVariables = txtSize.Text.Split(' ');
            int x = int.Parse(sizeVariables[0]);
            int y = int.Parse(sizeVariables[1]);

            switch (traveler.Direction)
            {
                case 'N':
                    traveler.Y = traveler.Y + 1 > y ? y : traveler.Y + 1;
                    break;

                case 'E':
                    traveler.X = traveler.X + 1 > x ? x : traveler.X + 1;
                    break;

                case 'S':
                    traveler.Y = traveler.Y - 1;
                    break;

                case 'W':
                    traveler.X = traveler.X - 1;
                    break;
            }
        }
        #endregion

        
    }
}
