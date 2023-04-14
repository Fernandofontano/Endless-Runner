using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyobject : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {        
        Destroy(this.gameObject);
        Debug.Log("cnsnal");
    }
}
