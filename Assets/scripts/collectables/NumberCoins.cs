using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberCoins : MonoBehaviour
{
    public static int coinCount;
    public GameObject coinCountdisplay;
    

    void Update()
    {
        coinCountdisplay.GetComponent<Text>().text = "" + coinCount;
    }
}
