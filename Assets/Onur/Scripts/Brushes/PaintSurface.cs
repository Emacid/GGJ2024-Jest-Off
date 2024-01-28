using UnityEngine;

public class PaintSurface : MonoBehaviour
{
    public Color brushColor = Color.blue;
    public GameObject BlueMarker;

    public Color GreyishColor = new Color(57, 57, 57);
    public Color WhiteColor = Color.white;
    public Color OrangeColor = new Color(255, 170, 1);


    private void Start()
    {
        brushColor = WhiteColor;
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
        if(brushColor == OrangeColor) 
        {
            brushColor = Color.white;
            BlueMarker.transform.position += new Vector3(-426, 0, 0);
        }
        else if(brushColor == GreyishColor) 
        {
            brushColor = OrangeColor;
            BlueMarker.transform.position += new Vector3(213, 0, 0);
        }
        else if(brushColor == Color.white) 
        {
            brushColor = GreyishColor;
            BlueMarker.transform.position += new Vector3(213, 0, 0);
        }
    }

   
        
        

}
