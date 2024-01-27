using UnityEngine;

public class PaintSurface2 : MonoBehaviour
{
    public Color brushColor = Color.blue;
    public GameObject RedMarker;


    private void Start()
    {
        brushColor = Color.green;
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            ChangeColor();
        }

        RaycastHit hit;
        Ray ray = new Ray(transform.position, Vector3.down);

        // Raycast kullanarak objenin alt�ndaki y�zeyi kontrol et
        if (Physics.Raycast(ray, out hit))
        {
            // E�er d��ey bir y�zey (�rne�in, bir plane) alg�lan�rsa, onu mavi renge boyay�n
            Renderer renderer = hit.collider.GetComponent<Renderer>();
            if (renderer != null)
            {
                // Ray'in �arpt��� y�zeyi mavi renge boyay�n
                renderer.material.color = brushColor;
            }
        }
    }

    private void ChangeColor()
    {
        if (brushColor == Color.blue)
        {
            brushColor = Color.green;
            RedMarker.transform.position += new Vector3(-426, 0, 0);
        }
        else if (brushColor == Color.red)
        {
            brushColor = Color.blue;
            RedMarker.transform.position += new Vector3(213, 0, 0);
        }
        else if (brushColor == Color.green)
        {
            brushColor = Color.red;
            RedMarker.transform.position += new Vector3(213, 0, 0);
        }
    }
}
