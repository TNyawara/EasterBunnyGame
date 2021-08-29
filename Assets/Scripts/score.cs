using TMPro;
using UnityEngine;

public class score : MonoBehaviour
{
    public TMP_Text score_text;
    public int current_score;
    // Start is called before the first frame update
    void Start()
    {
        current_score = 0;
        score_text.text = current_score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setScore(int plus)
    {
        current_score += plus;
        score_text.text = current_score.ToString();
    }
}
