using UnityEngine;

public class boundary : MonoBehaviour
{
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;

    private void Update()
    {
        
        Vector3 currentPosition = transform.position;

        
        currentPosition.x = Mathf.Clamp(currentPosition.x, minX, maxX);
        currentPosition.y = Mathf.Clamp(currentPosition.y, minY, maxY);

        
        transform.position = currentPosition;
    }
}
