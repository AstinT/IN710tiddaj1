using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MixAndMatch
{
    public class MonsterMaker
    {
        //Properties
        private String selectedHead;
        private String selectedTorso;
        private String selectedLegs;
        private PictureBox pbHead;
        private PictureBox pbTorso;
        private PictureBox pbLegs;

        //Factories
        IBodyPartFactory currFactory;

        public MonsterMaker(String selectedHead, String selectedTorso, String selectedLegs, PictureBox pbHead, PictureBox pbTorso, PictureBox pbLegs)
        {
            this.selectedHead = selectedHead;
            this.selectedTorso = selectedTorso;
            this.selectedLegs = selectedLegs;
            this.pbHead = pbHead;
            this.pbTorso = pbTorso;
            this.pbLegs = pbLegs;
        }

        public void createHead()
        {
            currFactory = new HeadFactory();
            BodyPart newHead = currFactory.createBodyPart(selectedHead);
            pbHead.Image = newHead.Image;
        }

        public void createTorso()
        {
            currFactory = new TorsoFactory();
            BodyPart newTorso = currFactory.createBodyPart(selectedTorso);
            pbTorso.Image = newTorso.Image;
        }

        public void createLegs()
        {
            currFactory = new LegsFactory();
            BodyPart newLegs = currFactory.createBodyPart(selectedLegs);
            pbLegs.Image = newLegs.Image;
        }
        
        public void createMonster()
        {
            createHead();
            createTorso();
            createLegs();
        }
    }
}
