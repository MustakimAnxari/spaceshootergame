using UnityEngine;

public class joystick : MonoBehaviour
{
    public float movementSpeed = 5f;
    public Transform playerTransform;

    private bool isTouching = false;
    private Vector2 touchStartPosition;

    private void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                isTouching = true;
                touchStartPosition = touch.position;
            }
            else if (touch.phase == TouchPhase.Ended || touch.phase == TouchPhase.Canceled)
            {
                isTouching = false;
            }
        }
        else
        {
            isTouching = false;
        }

        if (isTouching)
        {
            Vector2 touchDelta = (Vector2)Input.touches[0].position - touchStartPosition;
            float moveInput = Mathf.Clamp(touchDelta.x / Screen.width, -1f, 1f);
            float moveVelocity = moveInput * movementSpeed * Time.deltaTime;

            Vector3 newPosition = playerTransform.position + new Vector3(moveVelocity, 0f, 0f);
            playerTransform.position = newPosition;
        }
    }
}
