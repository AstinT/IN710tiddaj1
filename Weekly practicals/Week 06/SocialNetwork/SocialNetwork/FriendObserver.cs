using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocialNetwork
{
    public class FriendObserver : IObserver
    {
        //Properties
        private String newStatus;
        private ListBox displayBox;
        private StatusMonitor statusSubject;
        private DateTime timeStamp;

        //Constructor
        public FriendObserver(ListBox displayBox, StatusMonitor statusSubject)
        {
            this.displayBox = displayBox;
            this.statusSubject = statusSubject;

            newStatus = "";

            statusSubject.AddObserver(this);
        }

        public void Update(String newStatus)
        {
            this.newStatus = newStatus;
            timeStamp = DateTime.Now;
        }

        public void Display()
        {
            displayBox.Items.Add(timeStamp);
            displayBox.Items.Add(newStatus);
            displayBox.Items.Add("------------------------------");
        }        
    }
}
