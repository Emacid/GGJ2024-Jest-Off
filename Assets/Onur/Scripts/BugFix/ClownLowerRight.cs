using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClownLowerRight : MonoBehaviour
{

    public bool LowerRight;

    // Start is called before the first frame update
    void Start()
    {
        LowerRight = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TouchPointLR"))
        {
            //Debug.Log("Left Upper");
            LowerRight = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("TouchPointLR"))
        {
            //Debug.Log("Left Upper ");
            LowerRight = false;
        }
    }

}
