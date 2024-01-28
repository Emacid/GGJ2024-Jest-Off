using UnityEngine;

public class Boundy : MonoBehaviour
{
    public float minX = 2.39f;
    public float maxX = 21.2f;
    public float minZ = -17f;
    public float maxZ = 3f;

    void Update()
    {
        // Nesnenin hareketi burada kontrol edilir
        float newX = Mathf.Clamp(transform.position.x, minX, maxX);
        float newY = transform.position.y; // y eksenini deðiþtirmeye gerek yok
        float newZ = Mathf.Clamp(transform.position.z, minZ, maxZ);

        transform.position = new Vector3(newX, newY, newZ);
    }
}
