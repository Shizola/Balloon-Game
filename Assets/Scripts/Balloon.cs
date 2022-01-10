using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    public bool hasPopped;

    public void Pop()
    {
        hasPopped = true;
    }
}
