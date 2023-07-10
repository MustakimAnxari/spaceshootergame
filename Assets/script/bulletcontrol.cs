using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletcontrol : MonoBehaviour
{
    [SerializeField] private AudioSource hitsound;
    public float speed = 50f;

    private ScoreScript scoreScript;
    public int scoreValue = 0;
    private void Start()
    {
        scoreScript = FindObjectOfType<ScoreScript>();
    }


    private void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            
            scoreScript.IncreaseScore(scoreValue);
            Destroy(other.gameObject);
            Destroy(gameObject);
            hitsound.Play();
        }
    }
}
