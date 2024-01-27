using UnityEngine;

public class MoveRight : MonoBehaviour
{
    public float hareketHizi = 5f; // Nesnenin hareket h�z�

    void Update()
    {
        HareketEt(); // Her frame'de hareket etme fonksiyonunu �a��r
    }

    void HareketEt()
    {
        float hareketMiktari = hareketHizi * Time.deltaTime; // Hareket miktar�n� zamanla �arp

        // Nesneyi sa�a do�ru hareket ettir
        transform.Translate(Vector3.right * hareketMiktari);
    }
}
