using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2PointSystem : MonoBehaviour
{

    public bool insideLeftArrow;
    public bool insideUpArrow;
    public bool insideDownArrow;
    public bool insideRightArrow;
    public PointsP2 pointsP2;


    public GameObject redVfx;
    public GameObject greenVfx;
    public GameObject blueVfx;
    public GameObject purpleVfx;

    // Start is called before the first frame update
    void Start()
    {
        insideLeftArrow = false;
        insideUpArrow = false;
        insideDownArrow = false;
        insideRightArrow = false;

    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.LeftArrow) && insideLeftArrow)
        {
            Debug.Log("YOU GOT Left Arrow!");
            insideLeftArrow = false;
            pointsP2.pointP2 += 10;
            redVfx.gameObject.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) && insideUpArrow)
        {
            Debug.Log("YOU GOT Up Arrow!");
            insideUpArrow = false;
            pointsP2.pointP2 += 10;
            blueVfx.gameObject.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow) && insideDownArrow)
        {
            Debug.Log("YOU GOT Down Arrow!");
            insideDownArrow = false;
            pointsP2.pointP2 += 10;
            purpleVfx.gameObject.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) && insideRightArrow)
        {
            Debug.Log("YOU GOT Right Arrow!");
            insideRightArrow = false;
            pointsP2.pointP2 += 10;
            greenVfx.gameObject.SetActive(true);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("CheckBoxLeft"))
        {
            Debug.Log("Inside Left zone");
            insideLeftArrow = true;

        }

        else if (other.CompareTag("CheckBoxUp"))
        {
            Debug.Log("Inside Up zone");
            insideUpArrow = true;
        }

        else if (other.CompareTag("CheckBoxDown"))
        {
            Debug.Log("Inside Down zone");
            insideDownArrow = true;
        }

        else if (other.CompareTag("CheckBoxRight"))
        {
            Debug.Log("Inside Right zone");
            insideRightArrow = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("CheckBoxLeft"))
        {
            Debug.Log("exited Left zone");
            insideLeftArrow = false;
        }
        else if (other.CompareTag("CheckBoxUp"))
        {
            Debug.Log("exited Up zone");
            insideUpArrow = false;
        }
        else if (other.CompareTag("CheckBoxDown"))
        {
            Debug.Log("exited Down zone");
            insideDownArrow = false;
        }
        else if (other.CompareTag("CheckBoxRight"))
        {
            Debug.Log("exited Right zone");
            insideRightArrow = false;
        }

    }

}
