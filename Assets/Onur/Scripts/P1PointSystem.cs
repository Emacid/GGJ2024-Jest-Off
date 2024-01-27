using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1PointSystem : MonoBehaviour
{

    public bool insideLeftArrow;
    public bool insideUpArrow;
    public bool insideDownArrow;
    public bool insideRightArrow;
    public PointsP1 pointsP1;

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
       

        if (Input.GetKeyDown(KeyCode.A) && insideLeftArrow)
        {
            Debug.Log("YOU GOT A!");
            insideLeftArrow = false;
            pointsP1.pointP1 += 10;
        }

        if (Input.GetKeyDown(KeyCode.W) && insideUpArrow)
        {
            Debug.Log("YOU GOT W!");
            insideUpArrow = false;
            pointsP1.pointP1 += 10;
        }

        if (Input.GetKeyDown(KeyCode.S) && insideDownArrow)
        {
            Debug.Log("YOU GOT S!");
            insideDownArrow = false;
            pointsP1.pointP1 += 10;
        }

        if (Input.GetKeyDown(KeyCode.D) && insideRightArrow)
        {
            Debug.Log("YOU GOT D!");
            insideRightArrow = false;
            pointsP1.pointP1 += 10;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("CheckBoxA"))
        {
            Debug.Log("Inside A zone");
            insideLeftArrow = true;

        }

        else if (other.CompareTag("CheckBoxW")) 
        {
            Debug.Log("Inside W zone");
            insideUpArrow = true;
        }
        
        else if (other.CompareTag("CheckBoxS"))
        {
            Debug.Log("Inside S zone");
            insideDownArrow = true;
        }

        else if (other.CompareTag("CheckBoxD"))
        {
            Debug.Log("Inside D zone");
            insideRightArrow = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("CheckBoxA"))
        {
            Debug.Log("exited A zone");
            insideLeftArrow = false;
        }
        else if (other.CompareTag("CheckBoxW")) 
        {
            Debug.Log("exited W zone");
            insideUpArrow = false;
        }
        else if (other.CompareTag("CheckBoxS"))
        {
            Debug.Log("exited S zone");
            insideDownArrow = false;
        }
        else if (other.CompareTag("CheckBoxD"))
        {
            Debug.Log("exited D zone");
            insideRightArrow = false;
        }

    }

}
