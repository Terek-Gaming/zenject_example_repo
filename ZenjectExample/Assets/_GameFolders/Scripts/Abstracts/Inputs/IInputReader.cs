using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ZenjectExample.Abstracts.Inputs
{
    public interface IInputReader
    {
        Vector2 Direction { get; }
        bool IsButtonDown { get; }
    }    
}