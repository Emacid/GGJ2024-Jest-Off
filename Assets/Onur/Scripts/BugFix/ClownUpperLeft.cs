using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClownUpperLeft : MonoBehaviour
{

    public bool LeftUp;

    // Start is called before the first frame update
    void Start()
    {
        LeftUp = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TouchPointLU"))
        {
            //Debug.Log("Left Upper");
            LeftUp = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("TouchPointLU"))
        {
            //Debug.Log("Left Upper ");
            LeftUp = false;
        }
    }

}
