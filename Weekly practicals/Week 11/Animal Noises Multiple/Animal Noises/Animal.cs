using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading;

namespace Animal_Noises
{
    public class Animal
    {
        //Fields
        private SoundPlayer soundPlayer;
        private String locker;
        
        //Constructor
        public Animal(String locker, String soundFileName)
        {
            soundPlayer = new SoundPlayer(soundFileName);
            this.locker = locker;
        }

        //Method
        public void speak()
        {
            while (true)
            {
                //Lock on variable locker
                lock(locker)
                {
                    soundPlayer.Play();
                    Thread.Sleep(500);
                }                    
            }                 
        }
    }
}
