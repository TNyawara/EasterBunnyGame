using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EggScore : MonoBehaviour
{
     public TMP_Text eggscore_text;
    public int current_score;
    // Start is called before the first frame update
    void Start()
    {
        current_score = 0;
        eggscore_text.text = current_score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setScore(int plus)
    {
        current_score += plus;
        eggscore_text.text = current_score.ToString();
    }
}
