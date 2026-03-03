using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement Verticale")] 
    public float VerticalSpeed = 5;
    
    [Header("Movement Horizontale")]
    public float HorizontalSpeed = 13;

    public Transform transformWorld;

    [Header("Limite")] 
    public float MinHeight;
    public float MaxHeight = 27;
    
    
    void Update()
    {
        if (transform.position.y < MaxHeight && Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.up * (VerticalSpeed * Time.deltaTime);
        }
        else if (transform.position.y > MinHeight && Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.down * (VerticalSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transformWorld.Rotate(Vector3.up, HorizontalSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transformWorld.Rotate(-Vector3.up, HorizontalSpeed * Time.deltaTime);
        }
    }
    
    
}
