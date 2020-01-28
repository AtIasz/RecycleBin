using System;
using System.Collections.Generic;
using System.Text;

namespace RecycleTheTrashPpl
{
    class Dustbin
    {
        
        private string color;
        private PaperGarbage[] paperContent;
        private PlasticGarbage[] plasticContent;
        private Garbage[] houseWasteContent;

        public PaperGarbage[] GetPaperContent()
        {
            return paperContent;
        }

        public PlasticGarbage[] GetPlasticContent()
        {
            return plasticContent;
        }
        public Garbage[] GetHouseWasteContent()
        {
            return houseWasteContent;
        }
        public void DisplayContents()
        {
            for (int i = 0; i < houseWasteContent.Length; i++)
            {
                Console.WriteLine(houseWasteContent[i]);
            }
        }
        public void ThrowOutGarbage(Garbage garbage)
        {
            throw new DustbinContentException();

            if (garbage is PlasticGarbage){
                PlasticGarbage plasticGarbage = (PlasticGarbage)garbage;
                if (plasticGarbage.isClean)
                    {
                int newLength = PlasticContent.Length + 1;
                    PlasticContent = new PlasticGarbage[newLength];
                    PlasticContent[newLength-1] = plasticGarbage;
                    Console.WriteLine("plastic +1!");
                }
                else 
                {
                throw DustbinContentException();
                }
             else
                {

                }
            }

        }
        
    }
}
