using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class death : MonoBehaviour
{
    // Start is called before the first frame update

   
    [SerializeField] private AudioSource deathsound;
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Die();
        }
    }
    private void Die()
    {
        deathsound.Play();
        Destroy(gameObject);
        // Restart();
    }
    private void Restart()
    {
        SceneManager.LoadScene(1);
    }
}
