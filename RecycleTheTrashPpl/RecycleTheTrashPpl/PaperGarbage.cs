using System;
using System.Collections.Generic;
using System.Text;

namespace RecycleTheTrashPpl
{
    class PaperGarbage
    {
        
        private string name;
        private bool isSqueezed;

        public PaperGarbage(String name, bool isSqueezed)
        {
            name = this.name;
            isSqueezed = this.isSqueezed;
        }

        void Squeeze()
        {
            isSqueezed = true;
        }
        bool IsSqueezed()
        {
            return isSqueezed;
        }
    }
}
