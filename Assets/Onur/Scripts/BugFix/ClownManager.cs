using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
            StartCoroutine(finishSceneBro());
            
        }

        
    }

    IEnumerator finishSceneBro() 
    {
        yield return new WaitForSeconds(3);
        animator.SetBool("CloseTheScene", true);
        StartCoroutine(ChangeSceneBro());
    }

    IEnumerator ChangeSceneBro() 
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("SecondCutsene");
    }

}
