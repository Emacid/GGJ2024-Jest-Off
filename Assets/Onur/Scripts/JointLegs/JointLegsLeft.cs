using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JointLegsLeft : MonoBehaviour
{
    public GameObject jointLegLeft;

    void Start()
    {

    }

    private bool rotate = false;
    public float rotationSpeed = 300f;

    void Update()
    {
        jointLegLeft.transform.rotation *= Quaternion.Euler(0, 0, -250f * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.O))
        {
            rotate = true;
        }

        if (Input.GetKeyUp(KeyCode.O))
        {
            rotate = false;
        }

        if (rotate)
        {
            float rotationAmount = rotationSpeed * Time.deltaTime;
            jointLegLeft.transform.rotation *= Quaternion.Euler(0, 0, rotationAmount);
        }
    }
}
