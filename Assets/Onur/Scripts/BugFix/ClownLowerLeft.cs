using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClownLowerLeft : MonoBehaviour
{

    public bool LowerLeft;


    // Start is called before the first frame update
    void Start()
    {
        LowerLeft = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TouchPointLL"))
        {
            //Debug.Log("Left Upper");
            LowerLeft = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("TouchPointLL"))
        {
            //Debug.Log("Left Upper ");
            LowerLeft = false;
        }
    }

}
