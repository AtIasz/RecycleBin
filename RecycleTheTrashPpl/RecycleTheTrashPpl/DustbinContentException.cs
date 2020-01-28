using System;
using System.Collections.Generic;
using System.Text;

namespace RecycleTheTrashPpl
{
    public class DustbinContentException : Exception
    {
        public DustbinContentException()
        {

        }
        public DustbinContentException(string message)
        : base(message)
        {
            
        }
    }
}
