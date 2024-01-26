using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JointLegsRight : MonoBehaviour
{
    public GameObject jointLegRight;

    void Start()
    {

    }

    private bool rotate = false;
    public float rotationSpeed = 300f;

    void Update()
    {
        jointLegRight.transform.rotation *= Quaternion.Euler(0, 0, -250f * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.P))
        {
            rotate = true;
        }

        if (Input.GetKeyUp(KeyCode.P))
        {
            rotate = false;
        }

        if (rotate)
        {
            float rotationAmount = rotationSpeed * Time.deltaTime;
            jointLegRight.transform.rotation *= Quaternion.Euler(0, 0, rotationAmount);
        }
    }
}
