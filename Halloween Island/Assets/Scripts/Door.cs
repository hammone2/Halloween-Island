using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [Header("Coordinates")]
    public Vector2 teleportPosition;

    void OnTriggerEnter2D(Collider2D collision)
    {
        //if (!PhotonNetwork.IsMasterClient)
            //return;
        if (collision.CompareTag("Player"))
        {
            PlayerController player = collision.gameObject.GetComponent<PlayerController>();
            player.transform.position = teleportPosition;
        }
    }
}
