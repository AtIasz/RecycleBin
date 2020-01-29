using System;
using System.Collections.Generic;
using System.Text;

namespace RecycleTheTrashPpl
{
    class PlasticGarbage : Garbage
    {


        public bool isClean;

        public PlasticGarbage(string garbageName, bool isClean) : base(garbageName)
        {
            
            this.isClean = isClean;
        }

        public void Clean()
        {
            isClean = true;
        }

        public bool IsClean()
        {
            return isClean;
        }
        
    }
}
