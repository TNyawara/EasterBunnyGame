using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitStone : MonoBehaviour
{
    // Start is called before the first frame update
     public AudioSource AudioManager;
    
    void OnTriggerEnter(Collider other)
    {
        
            //Debug.Log("Collide");
            AudioManager.Play();
            this.gameObject.SetActive(false);
            //score.setScore(5);
    }
}
