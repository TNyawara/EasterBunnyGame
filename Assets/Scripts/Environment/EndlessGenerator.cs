using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndlessGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] section;
    public int zPos = 48;
    public bool creatingSection = false;
    public int secNum;
    // Update is called once per frame
    void Update()
    {
        if (creatingSection == false)
        {
            creatingSection = true;
            StartCoroutine(GenerateSection());
        }
    }
    IEnumerator GenerateSection()
    {
        secNum = Random.Range(0, 3);
        Instantiate(section[secNum], new Vector3(0,0,zPos), Quaternion.identity);
        zPos += 200;
        yield return new WaitForSeconds(2);
        creatingSection = false;
    }
}
