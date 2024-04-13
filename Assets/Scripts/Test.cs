using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    //Home number nothing more
    public float NumberOne;
    public float NumberTwo;
    public float Result;

    public bool ConsolBool;

    private void Start()
    {
        Sum();
    }
    private void Sum()
    {
        Result = NumberOne + NumberTwo;
        Debug.Log(Result);

    }

}
