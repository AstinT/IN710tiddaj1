using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControlHandlers
{
    //CustomHandlerObserver class
    public class CustomHandlerObserver
    {
        //Properties
        private Button btnSubject;
        private int codeNum;

        //Constructor
        public CustomHandlerObserver(Button btnSubject, int codeNum)
        {
            this.btnSubject = btnSubject;
            this.codeNum = codeNum;

            //Subscribe to Click event 
            btnSubject.Click += new System.EventHandler(ClickEvent);
        }

        //When button is clicked, display message
        public void ClickEvent(object sender, EventArgs e)
        {
            String msg = "";

            msg += "This is a custom handler.\n\n";
            msg += "My code number is " + codeNum + ".\n\n";
            msg += "My type is CustomControlHandlers.CustomHandlerObserver.\n\n";
            msg += "I am responding to buttons: btnTestHandlers.";

            MessageBox.Show(msg);
        }
    }
}
