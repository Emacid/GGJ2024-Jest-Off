using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneClose : MonoBehaviour
{

    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CloseTheSceneDude());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator CloseTheSceneDude() 
    {
        yield return new WaitForSeconds(25);
        animator.SetBool("CloseIt", true);
        StartCoroutine(ChangeScene());
    }

    IEnumerator ChangeScene()
    {
        yield return new WaitForSeconds(5);
     
        SceneManager.LoadScene("OnurScene");
    }
}
