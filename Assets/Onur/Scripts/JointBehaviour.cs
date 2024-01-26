using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JointBehaviour : MonoBehaviour
{
    public GameObject jointArm;

    void Start()
    {
        
    }

    private bool rotate = false;
    public float rotationSpeed = 300f;

    void Update()
    {
        gameObject.transform.rotation *= Quaternion.Euler(0, 0, -250f * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.E))
        {
            rotate = true;
        }

        if (Input.GetKeyUp(KeyCode.E))
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
