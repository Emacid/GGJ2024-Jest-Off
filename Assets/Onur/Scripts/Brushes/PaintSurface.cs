using UnityEngine;

public class PaintSurface : MonoBehaviour
{
    public Color brushColor = Color.blue;
    public GameObject BlueMarker;
    
    
    private void Start()
    {
        brushColor = Color.green;
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E)) 
            {
            ChangeColor();
            
            }

        RaycastHit hit;
        Ray ray = new Ray(transform.position, Vector3.down);

        // Raycast kullanarak objenin altýndaki yüzeyi kontrol et
        if (Physics.Raycast(ray, out hit))
        {
            // Eðer düþey bir yüzey (örneðin, bir plane) algýlanýrsa, onu mavi renge boyayýn
            Renderer renderer = hit.collider.GetComponent<Renderer>();
            if (renderer != null)
            {
                // Ray'in çarptýðý yüzeyi mavi renge boyayýn
                renderer.material.color = brushColor;
            }
        }
    }

    private void ChangeColor() 
    {
        if(brushColor == Color.blue) 
        {
            brushColor = Color.green;
            BlueMarker.transform.position += new Vector3(-426, 0, 0);
        }
        else if(brushColor == Color.red) 
        {
            brushColor = Color.blue;
            BlueMarker.transform.position += new Vector3(213, 0, 0);
        }
        else if(brushColor == Color.green) 
        {
            brushColor= Color.red;
            BlueMarker.transform.position += new Vector3(213, 0, 0);
        }
    }

   
        
        

}
