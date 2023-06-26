using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score: MonoBehaviour
{
    private int count = 0;

    [SerializeField] private Text counttext;
    [SerializeField] private AudioSource collect;
    // Start is called before the first frame update

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            collect.Play();
           // Destroy(collision.gameObject);
            count++;
            counttext.text = "count" + count;
        }
    }
    private void Update()
    {
        counttext.text = "Score " + count;
    }
}
