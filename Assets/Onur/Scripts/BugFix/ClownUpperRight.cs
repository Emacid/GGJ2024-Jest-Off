using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClownUpperRight : MonoBehaviour
{

    public bool RightUp;

    // Start is called before the first frame update
    void Start()
    {
        RightUp = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TouchPointRU"))
        {
            //Debug.Log("Left Upper");
            RightUp = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("TouchPointRU"))
        {
            //Debug.Log("Left Upper ");
            RightUp = false;
        }
    }

}
