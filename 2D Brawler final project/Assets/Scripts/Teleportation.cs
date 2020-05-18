using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleportation : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Portal;
    public GameObject Player;


    public void OnTriggerEnter2D(Collider2D other)
    {
        Player.transform.position = Portal.transform.position;
    }

}
