using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointsP1 : MonoBehaviour
{
    public int pointP1;
    public TextMeshProUGUI pointP1Text; 

    // Start is called before the first frame update
    void Start()
    {
        pointP1 = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdatePointText();
        
    }

    void UpdatePointText()
    {
        // TextMeshPro nesnesinin text de�erini pointP1'in de�eriyle g�ncelle
        pointP1Text.text = pointP1.ToString();
    }
}
