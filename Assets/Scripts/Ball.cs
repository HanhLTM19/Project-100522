using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed;
    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        if ((transform.position.x <= -4.2 && moveHorizontal < 0) || (transform.position.x >= 4.2 && moveHorizontal > 0)
            || (transform.position.z <= 6.5 && moveVertical < 0)) 
        {
            return;
        }
        Vector3 movenent = new Vector3(moveHorizontal, 0.0f, moveVertical);
        transform.position += movenent;
    }
}
