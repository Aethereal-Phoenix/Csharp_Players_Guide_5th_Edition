using System;
using System.Collections.Generic;
using System.Text;

namespace Lvl16_C1_Simula_s_Test
{
    internal enum LockStatus
    {
        Open, // If open can only go to closed
        Closed, // Can move to open or locked
        Locked // if Locked can only go to closed
    }
}
