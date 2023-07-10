using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemycontroller : MonoBehaviour

{
    public float speed = 7f;

    private void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
    }
}

