using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClownManager : MonoBehaviour
{
    public ClownUpperLeft clownUpperLeft;
    public ClownUpperRight clownUpperRight;
    public ClownLowerLeft clownLowerLeft;
    public ClownLowerRight clownLowerRight;

    public GameObject winSFX;
    public GameObject splendidText;

    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(clownUpperLeft.LeftUp);
        Debug.Log(clownUpperRight.RightUp);
        Debug.Log(clownLowerLeft.LowerLeft);
        Debug.Log(clownLowerRight.LowerRight);

        if(clownUpperLeft.LeftUp && clownUpperRight.RightUp && clownLowerLeft.LowerLeft && clownLowerRight.LowerRight) 
        {
            winSFX.SetActive(true);
            splendidText.SetActive(true);
            Debug.Log("WIN!!!");
            
        }

        if(Input.GetKeyUp(KeyCode.N)) 
        {
            animator.SetBool("CloseTheScene", true);
        }
    }
}
