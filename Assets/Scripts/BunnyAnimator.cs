using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BunnyAnimator : MonoBehaviour
{
    public Animator anim;

    void Update()
    {
        anim.Play("Running");
       // if(Input.GetKey(KeyCode.A)){
        //anim.Play("idle");
        //}
        //if(Input.GetKey(KeyCode.S)){
       // anim.Play("Dead");
        //}
        //if(Input.GetKey(KeyCode.D)){
       // anim.Play("0-idle_agressive");
        //}
    }
}
