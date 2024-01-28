using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToNextScene : MonoBehaviour
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
        yield return new WaitForSeconds(8.5f);

        SceneManager.LoadScene("PaintingScene");
    }
}
