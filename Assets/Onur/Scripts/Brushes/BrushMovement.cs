using UnityEngine;

public class BrushMovement : MonoBehaviour
{
    public float movementSpeed = 5f;

    void Update()
    {
        // W-S tuşları ile Z ekseninde hareket
        float verticalMovement = Input.GetAxis("Vertical");
        Vector3 verticalVector = new Vector3(0f, 0f, verticalMovement) * movementSpeed;

        // A-D tuşları ile X ekseninde hareket
        float horizontalMovement = Input.GetAxis("Horizontal");
        Vector3 horizontalVector = new Vector3(horizontalMovement, 0f, 0f) * movementSpeed;

        // Hareket vektörlerini birleştirerek karakteri hareket ettir
        Vector3 movement = verticalVector + horizontalVector;
        transform.Translate(movement * Time.deltaTime);
    }
}