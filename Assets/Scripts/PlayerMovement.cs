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
    public float moveSpeed = 3;
    public float horizontalSpeed = 4;

     void Update() {
        MainCamera.enabled = true;
        AerialCamera.enabled = false;
        SideCamera.enabled = false;
        rabbit.transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed, Space.World);

        if (Input.GetKey(KeyCode.UpArrow)) {
            rabbit.transform.Translate(0f,0f,0.5f);
        }
        if (Input.GetKey(KeyCode.DownArrow)) {
            rabbit.transform.Translate(0f,0f,-0.5f);
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)) {
            if(rabbit.transform.position.x > LevelBoundary.leftSide)
            {
                rabbit.transform.Translate(Vector3.left * Time.deltaTime * horizontalSpeed);
            }
            
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)) {
            if(rabbit.transform.position.x < LevelBoundary.rightSide)
            {
                rabbit.transform.Translate(Vector3.left * Time.deltaTime * horizontalSpeed * -1);
            }
        }
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            rabbit.transform.Translate(Vector3.up * Time.deltaTime * moveSpeed);
        }
            if (Input.GetKey(KeyCode.J)){
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