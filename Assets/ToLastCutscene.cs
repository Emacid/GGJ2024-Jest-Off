using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToLastCutscene : MonoBehaviour
{
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
        yield return new WaitForSeconds(66f);

        SceneManager.LoadScene("ThirdCutscene");
    }

}