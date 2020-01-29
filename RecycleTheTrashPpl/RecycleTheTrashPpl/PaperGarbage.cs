using System;
using System.Collections.Generic;
using System.Text;

namespace RecycleTheTrashPpl
{
    class PaperGarbage : Garbage
    {

        
        private bool isSqueezed;

        public PaperGarbage(string garbageName ,bool isSqueezed) : base(garbageName)
        {
            
            this.isSqueezed = isSqueezed;
        }

        public void Squeeze()
        {
            isSqueezed = true;
        }
        public bool IsSqueezed()
        {
            return isSqueezed;
        }
    }
}
