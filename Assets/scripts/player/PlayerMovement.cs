using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movespeed = 3f;
    public float leftrightspeed = 4;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * movespeed, Space.World);
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            if (this.gameObject.transform.position.x > levelboundary.leftside)
            {
                transform.Translate(Vector3.left * Time.deltaTime * leftrightspeed);
            }

        }
        transform.Translate(Vector3.forward * Time.deltaTime * movespeed, Space.World);
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            if (this.gameObject.transform.position.x < levelboundary.rightside)
            {
                transform.Translate(Vector3.left * Time.deltaTime * leftrightspeed * -1);
            }
        }
    }
}
