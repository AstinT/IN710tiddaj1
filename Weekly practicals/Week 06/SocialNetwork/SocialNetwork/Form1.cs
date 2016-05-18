using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocialNetwork
{
    public partial class Form1 : Form
    {
        //Properties
        private StatusMonitor StatusSubject;

        //Constructor
        public Form1()
        {
            InitializeComponent();

            StatusSubject = new StatusMonitor();

            new FriendObserver(lbFriend1, StatusSubject);
            new FriendObserver(lbFriend2, StatusSubject);
            new FriendObserver(lbFriend3, StatusSubject);
            new FriendObserver(lbFriend4, StatusSubject);
        }

        //Click method
        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (tbUpdateStatus.Text != "")
            {
                StatusSubject.NewStatus = tbUpdateStatus.Text;
                StatusSubject.NotifyObservers();

                lbMain.Items.Clear();
                lbMain.Items.Add(tbUpdateStatus.Text);
                
                tbUpdateStatus.Text = "";
            }
            else
                MessageBox.Show("Please enter a status.");            
        }
    }
}
