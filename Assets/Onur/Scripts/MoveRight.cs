using UnityEngine;

public class MoveRight : MonoBehaviour
{
    public float hareketHizi = 5f; // Nesnenin hareket hýzý

    void Update()
    {
        HareketEt(); // Her frame'de hareket etme fonksiyonunu çaðýr
    }

    void HareketEt()
    {
        float hareketMiktari = hareketHizi * Time.deltaTime; // Hareket miktarýný zamanla çarp

        // Nesneyi saða doðru hareket ettir
        transform.Translate(Vector3.right * hareketMiktari);
    }
}
