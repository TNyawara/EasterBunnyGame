using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    //public int speed=30;
    //bool isMoving=false;
    public GameObject player;
    public GameObject doozy;
    public Animator anim;
    public Rigidbody stone;
    public Camera MainCamera;
    public Camera AerialCamera;
    public Camera SideCamera;
    public int current_level;
    public Level level;
    public float moveSpeed = 10;
    public float horizontalSpeed = 4;
    private Rigidbody rb;
    public Vector3 startingPoint;
    public Vector3 currentPosition;
    void Start()
    {
        rb = doozy.GetComponent<Rigidbody>();
        startingPoint = doozy.transform.position;
    }

     void Update() {
        MainCamera.enabled = true;
        AerialCamera.enabled = false;
        SideCamera.enabled = false;
        currentPosition = doozy.transform.position;
        current_level = level.getLevel();
        if(current_level == 3)
        {
            if(Input.GetKeyDown(KeyCode.Return))
            {
                Rigidbody rb = Instantiate(stone, transform.position, transform.rotation) as Rigidbody;
                rb.AddForce(transform.forward * 100);
                rb.AddForce(transform.up * 80);
            }
        }
       //player.transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed, Space.World);

        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)) {
            //player.transform.Translate(0f,0f,0.5f);
            player.transform.Translate(Vector3.forward * Time.deltaTime * 20, Space.World);
           // doozy.transform.Translate(0f,0f,0.5f);
          //  MainCamera.transform.Translate(0f, 0f, 0.5f);
            anim.Play("Running");
        }

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)) {
            if(player.transform.position.x > LevelBoundary.leftSide)
            {
                player.transform.Translate(Vector3.left * Time.deltaTime * horizontalSpeed);
                doozy.transform.Translate(Vector3.left * Time.deltaTime * horizontalSpeed);
                MainCamera.transform.Translate(Vector3.left * Time.deltaTime * horizontalSpeed);
            }
            
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)) {
            if(player.transform.position.x < LevelBoundary.rightSide)
            {
                player.transform.Translate(Vector3.left * Time.deltaTime * horizontalSpeed * -1);
                doozy.transform.Translate(Vector3.left * Time.deltaTime * horizontalSpeed * -1);
                MainCamera.transform.Translate(Vector3.left * Time.deltaTime * horizontalSpeed * -1);
            }
        }

        if (Input.GetKeyDown(KeyCode.Space) && Input.GetKey(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.Space) && Input.GetKey(KeyCode.W))
        {
            anim.Play("Jumping");
            //player.transform.Translate(0f, 1f, 0f);
            //MainCamera.transform.Translate(0f, 1f, 0f);
            //rb.AddForce(Vector3.up * 100.0f, ForceMode.Impulse);
            player.transform.Translate(Vector3.up * Time.deltaTime * 25, Space.World);
            StartCoroutine(Jumping());   
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

    IEnumerator Jumping()
    {
        yield return new WaitForSeconds(1);
        player.transform.Translate(Vector3.up * Time.deltaTime * 25 *-1, Space.World);
    }

  
   
}