using System;
using System.Collections.Generic;
using System.Text;

namespace RecycleTheTrashPpl
{
    class PaperGarbage : Garbage
    {

        private string name;
        private bool isSqueezed;

        public PaperGarbage(string name, bool isSqueezed)
        {
            this.name = name;
            this.isSqueezed = isSqueezed;
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
