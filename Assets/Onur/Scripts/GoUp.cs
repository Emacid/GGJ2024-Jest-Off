using UnityEngine;

public class GoUp : MonoBehaviour
{
    public float speed = 2.0f; // Yukarý hareket hýzý

    void Update()
    {
        MoveUp(); // Sürekli olarak yukarý hareket etmesini saðlamak için her güncelleme adýmýnda çaðýrýn
    }

    void MoveUp()
    {
        // Y ekseni üzerinde nesnenin konumunu güncelleme
        transform.position += Vector3.up * speed * Time.deltaTime;
    }
}
