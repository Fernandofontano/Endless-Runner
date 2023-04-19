using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemmovement : MonoBehaviour
{
    public int rotateSpeed = 1;
    // Update is called once per frame
    void Update()
    {
       transform.Rotate(0, rotateSpeed, 0, Space.World);
    }
    
}
