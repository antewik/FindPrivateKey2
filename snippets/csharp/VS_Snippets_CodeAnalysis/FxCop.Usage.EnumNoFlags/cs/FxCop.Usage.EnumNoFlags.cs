//<Snippet1>
using System;

namespace Samples
{    
    // Violates this rule    
    [Flags]        
    public enum Color
    { 
        None    = 0, 
        Red     = 1, 
        Orange  = 3, 
        Yellow  = 4 
    }
}

//</Snippet1>