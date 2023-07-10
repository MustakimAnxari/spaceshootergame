using UnityEngine;
using UnityEngine.UI;

public class firebutton : MonoBehaviour
{
    public Button fireButton;
    public GameObject bulletPrefab;
    public Transform firePoint;

    private void Start()
    {
        fireButton.onClick.AddListener(OnFireButtonClick);
    }

    public void OnFireButtonClick()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}