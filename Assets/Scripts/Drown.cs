using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drown : MonoBehaviour
{
    public PlayerMovement player;
    private void OnTriggerEnter(Collider other)
    {
        player.Die();
    }
}
