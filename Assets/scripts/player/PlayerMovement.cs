using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movespeed = 5;
    public float leftrightspeed = 4;
    public bool isjumping = false;
    public bool comingDown = false;

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
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            if (this.gameObject.transform.position.x < levelboundary.rightside)
            {
                transform.Translate(Vector3.left * Time.deltaTime * leftrightspeed * -1);
            }
        }
        if (Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.W))
        {
            if (isjumping == false)
            {
                isjumping = true;
            }
            StartCoroutine(jumpsecuense());
        }
        if (isjumping == true)
        {
            if (comingDown == false)
            {
                transform.Translate(Vector3.up * Time.deltaTime * 4, Space.World);
            }
            if (comingDown == true)
            {
                transform.Translate(Vector3.up * Time.deltaTime * -4, Space.World);

            }
        }
        IEnumerator jumpsecuense ()
        {
            yield return new WaitForSeconds(0.45F);
            comingDown = true;
            yield return new WaitForSeconds(0.45F);
            comingDown = false;
            isjumping = false;
        }
    }
}
