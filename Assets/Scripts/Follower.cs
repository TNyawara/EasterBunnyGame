using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower : MonoBehaviour
{
    public Transform target;//This is the transform property of the target = Sphere
    public Vector3 offset; //This is offset dimensions with respect to X,Y and Z
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //The new position of the camera is the same as that of the sphere BUT with some distance
    //in between (offset)
    transform.position = target.position +offset;
    }
}
