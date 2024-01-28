using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndOfAll : MonoBehaviour
{

    public Animator animator;
    public PointsP1 pointsP1;
    public PointsP2 pointsP2;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FinishTheLastScene());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator FinishTheLastScene() 
    {
        yield return new WaitForSeconds(37);
        animator.SetBool("Play", true);
    }

}
