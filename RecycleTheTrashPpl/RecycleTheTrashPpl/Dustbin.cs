using System;
using System.Collections.Generic;
using System.Text;

namespace RecycleTheTrashPpl
{
    class Dustbin
    {

        public string color { get; set; }
        public PaperGarbage[] paperContent { get; set; }
        public PlasticGarbage[] plasticContent { get; set; }
        public Garbage[] houseWasteContent { get; set; }

        public Dustbin ( string color)
        {
            this.color = color;
            paperContent = new PaperGarbage[0];
            plasticContent = new PlasticGarbage[0];
            houseWasteContent = new Garbage[0];

        }

        /*public PaperGarbage[] GetPaperContent()
        {
            return paperContent;
        }*/

       /* public PlasticGarbage[] GetPlasticContent()
        {
            return plasticContent;
        }
        public Garbage[] GetHouseWasteContent()
        {
            return houseWasteContent;
        }*/
        public void DisplayContents()
        {
            Console.WriteLine("House waste content: "+ houseWasteContent.Length);
            foreach(Garbage trash in houseWasteContent)
            {
                if (trash != null)
                {
                    Console.WriteLine(trash.name);
                }
                
                
            }
            Console.WriteLine("Plastic trash content: " + plasticContent.Length);
            foreach (Garbage trash in plasticContent)
            {
                if (trash != null)
                {
                    Console.WriteLine(trash.name);
                }
                
                
            }
            Console.WriteLine("Paper trash content: " + paperContent.Length);
            foreach (Garbage trash in paperContent)
            {
                if (trash != null)
                {
                    Console.WriteLine(trash.name);
                }
                
                
            }
        }
        public void ThrowOutGarbage(Garbage garbage)
        {


            if (garbage is PlasticGarbage)
            {
                PlasticGarbage plasticTrash = (PlasticGarbage)garbage;
                if (plasticTrash.IsClean())
                {
                    int newLength = plasticContent.Length + 1;
                    plasticContent = new PlasticGarbage[newLength];
                    plasticContent[newLength - 1] = plasticTrash;
                    Console.WriteLine("Plastic +1");
                }
                else
                {
                    throw new DustbinContentException();
                }
            }
            else if (garbage is PaperGarbage)
            {
                PaperGarbage paperTrash = (PaperGarbage)garbage;
                if (paperTrash.IsSqueezed())
                {
                    int newLength = paperContent.Length + 1;
                    paperContent = new PaperGarbage[newLength];
                    paperContent[newLength - 1] = paperTrash;
                    Console.WriteLine("Paper +1");
                }
                else
                {
                    throw new DustbinContentException();
                }
            }
            else if(garbage is Garbage)
            {
                
                int newLength = houseWasteContent.Length + 1;
                var tmp = new Garbage[newLength];
                for (int i = 0; i < houseWasteContent.Length; i++)
                {
                    tmp[i] = houseWasteContent[i];
                }
                houseWasteContent = tmp;
                houseWasteContent[newLength - 1] = garbage;
                Console.WriteLine(" Housewaste +1 ");

            }
            else
            {
                throw new DustbinContentException();
            }
        }
        public void EmptyContents()
        {
            paperContent = new PaperGarbage[0];
            plasticContent = new PlasticGarbage[0];
            houseWasteContent = new Garbage[0];
        }
            

    }
}