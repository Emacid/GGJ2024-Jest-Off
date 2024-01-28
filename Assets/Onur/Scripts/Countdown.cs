using UnityEngine;
using TMPro;
using System.Collections;

public class Countdown : MonoBehaviour
{
    public TextMeshProUGUI countdownText;
    private float countdownTime = 60f;
    public Animator animator;

    void Start()
    {
        if (countdownText == null)
        {
            Debug.LogError("TextMeshPro nesnesi atanmam��!");
            return;
        }

        StartCoroutine(StartCountdown());
    }

    IEnumerator StartCountdown()
    {
        while (countdownTime > 0f)
        {
            countdownText.text = countdownTime.ToString("F0"); // F0, virg�l sonras� basamaklar� g�stermez
            yield return new WaitForSeconds(1f);
            countdownTime--;
            
        }

        countdownText.text = "Time is over!";
        StartCoroutine(FinishTheScene());
    }

    IEnumerator FinishTheScene() 
    {
        yield return new WaitForSeconds(2f);
        animator.SetBool("TimeIsOverMan", true);
    }

}
