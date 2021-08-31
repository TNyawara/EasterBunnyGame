using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectEgg : MonoBehaviour
{
  // public AudioSource coinFX;
   // public score score;
    void OnTriggerEnter(Collider other)
    {
        
            //Debug.Log("Collide");
            //coinFX.Play();
            this.gameObject.SetActive(false);
            //score.setScore(5);
    }
}
