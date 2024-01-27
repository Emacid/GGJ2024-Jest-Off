using UnityEngine;

public class wiggle : MonoBehaviour
{
    public float wiggleFrequency = 1.0f; // Sallanma frekans�
    public float wiggleAmplitude = 0.1f; // Sallanma genli�i

    private Vector3 originalPosition;

    void Start()
    {
        // Kuklan�n ba�lang�� pozisyonunu kaydedin
        originalPosition = transform.position;
    }

    void Update()
    {
        // Sallanma efektini hesapla
        float wiggleX = Mathf.Sin(Time.time * wiggleFrequency) * wiggleAmplitude;
        float wiggleY = Mathf.Cos(Time.time * wiggleFrequency) * wiggleAmplitude;

        // Yeni pozisyonu uygula
        transform.position = originalPosition + new Vector3(wiggleX, wiggleY, 0);
    }
}
