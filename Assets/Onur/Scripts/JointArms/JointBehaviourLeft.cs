using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JointBehaviourLeft : MonoBehaviour
{
    //public GameObject jointArmLeft;

    void Start()
    {

    }

    private bool rotate = false;
    public float rotationSpeed = 300f;

    void Update()
    {
        gameObject.transform.rotation *= Quaternion.Euler(0, 0, -250f * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Q))
        {
            rotate = true;
        }

        if (Input.GetKeyUp(KeyCode.Q))
        {
            rotate = false;
        }

        if (rotate)
        {
            float rotationAmount = rotationSpeed * Time.deltaTime;
            transform.rotation *= Quaternion.Euler(0, 0, rotationAmount);
        }
    }
}
