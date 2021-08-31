using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio : MonoBehaviour
{
  public AudioSource BGM;
    
    public void Sound(AudioClip Music){
    BGM.clip=Music;
    BGM.Play();
    
    }
}
