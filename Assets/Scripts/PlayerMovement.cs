using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    //public int speed=30;
    //bool isMoving=false;
    public Rigidbody rabbit;


    public Camera MainCamera;
    public Camera AerialCamera;
    public Camera SideCamera;
    void Start()
    {
        
    }

    // Update is called once per frame
     void Update() {
        //if (isMoving) {
         //   return;
        //}

        if (Input.GetKey(KeyCode.UpArrow)) {
            rabbit.transform.Translate(0f,0f,0.5f);
        }
        if (Input.GetKey(KeyCode.DownArrow)) {
           rabbit.transform.Translate(0f,0f,-0.5f);
        }
        if (Input.GetKey(KeyCode.LeftArrow)) {
            rabbit.transform.Translate(-0.5f,0f,0f);
        }
        if (Input.GetKey(KeyCode.RightArrow)) {
            rabbit.transform.Translate(0.5f,0f,0f);
        }
        if(Input.GetKey(KeyCode.J)){
            MainCamera.enabled = false;
            AerialCamera.enabled = true;
            SideCamera.enabled = false;
        
        }
        if(Input.GetKey(KeyCode.K)){
            MainCamera.enabled = true;
            AerialCamera.enabled = false;
            SideCamera.enabled = false;
        }
        if(Input.GetKey(KeyCode.L)){
            MainCamera.enabled = false;
            AerialCamera.enabled = false;
            SideCamera.enabled = true;
        }
    }

  
   
}