using UnityEngine;

public class GoUp : MonoBehaviour
{
    public float speed = 2.0f; // Yukar� hareket h�z�

    void Update()
    {
        MoveUp(); // S�rekli olarak yukar� hareket etmesini sa�lamak i�in her g�ncelleme ad�m�nda �a��r�n
    }

    void MoveUp()
    {
        // Y ekseni �zerinde nesnenin konumunu g�ncelleme
        transform.position += Vector3.up * speed * Time.deltaTime;
    }
}
