using TMPro;
using UnityEngine;

public class Level : MonoBehaviour
{
    public TMP_Text level_text;
    public int current_level;
    // Start is called before the first frame update
    void Start()
    {
        current_level = 1;
        level_text.text = current_level.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setLevel(int level)
    {
        current_level = level;
        level_text.text = current_level.ToString();
    }

    public int getLevel()
    {
        return current_level;
    }
}
