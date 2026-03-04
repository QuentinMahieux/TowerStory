using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform player;
    public float speed = 5;
    public float deadZone = 2;
    public float distancePlayer = 5;
    
    void LateUpdate()
    {
        float difference = transform.position.y - (player.position.y + distancePlayer);

        if (Mathf.Abs(difference) > deadZone)
        {
            float newTarget = player.position.y + distancePlayer; transform.position = new Vector3(transform.position.x, Mathf.Lerp(transform.position.y, newTarget, speed * Time.deltaTime), transform.position.z);
        }
    }
}