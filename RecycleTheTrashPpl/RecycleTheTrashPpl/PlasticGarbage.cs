using System;
using System.Collections.Generic;
using System.Text;

namespace RecycleTheTrashPpl
{
    class PlasticGarbage : Garbage
    {
        
        public string name;
        private bool isClean;

        public PlasticGarbage(string name, bool isClean)
        {
            this.name = name;
            this.isClean = isClean;
        }

        void Clean()
        {
            isClean = true;
        }

        bool IsClean()
        {
            return isClean;
        }
        
    }
}
