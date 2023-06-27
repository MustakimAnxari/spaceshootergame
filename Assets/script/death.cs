using UnityEngine;
using UnityEngine.SceneManagement;

public class death : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
          
            Destroy(gameObject);

          
            SceneManager.LoadScene(2);
        }
    }
}
