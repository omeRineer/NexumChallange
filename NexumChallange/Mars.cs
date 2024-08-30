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
        public Mars()
        {
            InitializeComponent();

            travelerList = new BindingList<Traveler>();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var locationVariables = txtLocation.Text.Split(' ');
            var infoVariables = txtInfo.Text;


            var newTraveler = new Traveler
            {
                Id = Guid.NewGuid(),
                Tag = txtTag.Text,
                X = int.Parse(locationVariables[0]),
                Y = int.Parse(locationVariables[1]),
                Direction = char.Parse(locationVariables[2]),
                InfoVariables = infoVariables
            };

            travelerList.Add(newTraveler);
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            lstTravelers.DataSource = travelerList;

            lstTravelers.ValueMember = "Id";
            lstTravelers.DisplayMember = "Name";
        }
    }
}
