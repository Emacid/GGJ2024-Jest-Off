using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToBossBattle : MonoBehaviour
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
        yield return new WaitForSeconds(6f);
        animator.SetBool("ComeOn", true);
        StartCoroutine(CloseTheSceneDude2());
    }

    IEnumerator CloseTheSceneDude2()
    {
        yield return new WaitForSeconds(2.7f);
        SceneManager.LoadScene("DanceScene");
    }

}
