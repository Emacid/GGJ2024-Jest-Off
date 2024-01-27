using UnityEngine;

public class wiggle : MonoBehaviour
{
    public float wiggleFrequency = 1.0f; // Sallanma frekansý
    public float wiggleAmplitude = 0.1f; // Sallanma genliði

    private Vector3 originalPosition;

    void Start()
    {
        // Kuklanýn baþlangýç pozisyonunu kaydedin
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
