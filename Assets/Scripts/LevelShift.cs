using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelShift : MonoBehaviour
{
    public Level level;
    public audio audio;
    public AudioClip levelsound;
    private void OnTriggerEnter(Collider other)
    {
    
        int current_level = level.getLevel();
        int next_level = current_level + 1;
        level.setLevel(next_level);
        audio.Sound(levelsound);
    }
}
