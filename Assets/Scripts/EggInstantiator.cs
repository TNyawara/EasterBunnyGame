using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggInstantiator : MonoBehaviour
{
    public GameObject Egg;
    public int EggCount=0;
    public float xPosition,zPosition;
    // Start is called before the first frame update
    void Start()
    {
     
    //yield return new WaitForSeconds(10.0f);
   /* while  (EggCount<30){
        xPosition=Random.Range(0.44f, 0.34f);
        zPosition=Random.Range(-0.42f, 0.36f);
        Instantiate(Egg, new Vector3(xPosition, 0.5f, zPosition),Quaternion.Euler(0,0,0));
    }*/
}
    
}
