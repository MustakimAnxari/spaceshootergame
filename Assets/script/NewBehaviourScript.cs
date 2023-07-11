using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public void Update()
    {
   
        float horizontalInput = Input.GetAxis("Horizontal");
        float currentPlayerX = transform.position.x;
        float xBoundLeft = -11.3f;
        float xBoundRight = 11.3f;
        float speed = 10f;



        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        if (currentPlayerX < xBoundLeft)
        {
            transform.position = new Vector2(xBoundRight, -4);
        }
        else if (currentPlayerX > xBoundRight)
        {
            transform.position = new Vector2(xBoundLeft, -4);
        }
    }
}
