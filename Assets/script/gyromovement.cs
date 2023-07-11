using UnityEngine;

public class gyromovement : MonoBehaviour
{
    private bool gyroEnabled;
    private Gyroscope gyro;
    public float moveSpeed = 10f;

    private void Start()
    {
        gyroEnabled = SystemInfo.supportsGyroscope;

        if (gyroEnabled)
        {
            gyro = Input.gyro;
            gyro.enabled = true;
        }
        else
        {
            Debug.LogWarning("Gyroscope is not supported on this device.");
        }
    }

    private void Update()
    {
        if (gyroEnabled)
        {
            Quaternion gyroRotation = gyro.attitude;
            float horizontalMovement = -gyroRotation.eulerAngles.y;
            Vector3 newPosition = transform.position + new Vector3(horizontalMovement, 0f, 0f) * moveSpeed * Time.deltaTime;
            transform.position = newPosition;
        }
    }
}
