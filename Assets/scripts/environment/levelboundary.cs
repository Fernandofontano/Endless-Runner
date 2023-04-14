using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelboundary : MonoBehaviour
{
    public static float leftside = -3.62f;
    public static float rightside = 3.74f;
    public float internalleft;
    public float internalright;
    // Update is called once per frame
    void Update()
    {
        internalleft = leftside;
        internalright = rightside;
    }
}
