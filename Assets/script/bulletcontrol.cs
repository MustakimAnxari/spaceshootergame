using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletcontrol : MonoBehaviour
{
  
    [SerializeField] private AudioSource destroysound;
    public GameObject destroysoundobject;
    private AudioSource destroybgm;

    public float speed = 50f;

    private ScoreScript scoreScript;
    public int scoreValue = 0;
    public ParticleSystem particleEffect;

    private void Start()
    {
        scoreScript = FindObjectOfType<ScoreScript>();
        destroysoundobject = GameObject.Find("music");
        destroybgm = destroysoundobject.GetComponent<AudioSource>();
        
    }


    private void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            // AudioSource.PlayClipAtPoint(destroysound, transform.position);
           destroybgm.Play();
           ParticleSystem  neweffect= Instantiate(particleEffect, transform.position, Quaternion.identity);
            
            scoreScript.IncreaseScore(scoreValue);
            Destroy(other.gameObject);
           // hitsound.Play();
            Destroy(gameObject);
            Destroy(neweffect.gameObject, neweffect.main.duration);

           
           
        }
    }
}
