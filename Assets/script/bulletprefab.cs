using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletprefab : MonoBehaviour

{
    [SerializeField] private AudioSource hitsound;
    public GameObject bulletPrefab;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            Instantiate(bulletPrefab, transform.position, transform.rotation);
            hitsound.Play();
        }
    }
}