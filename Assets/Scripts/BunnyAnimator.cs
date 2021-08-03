using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BunnyAnimator : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow)){
anim.Play("Running");
}
if(Input.GetKey(KeyCode.A)){
anim.Play("idle");
}
if(Input.GetKey(KeyCode.S)){
anim.Play("Dead");
}
//if(Input.GetKey(KeyCode.D)){
anim.Play("0-idle_agressive");
//}
    }
}
