using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private Transform previousRoom;
    [SerializeField] private Transform nextRoom;
    [SerializeField] private CameraController cam;

    public PlayerMovement playerMovement;
    // public int side = 1;

    private void Start()
    {
        Debug.Log(playerMovement.side);

    }

     private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log(playerMovement.side);
            if (playerMovement.side == 1)
            {
                cam.MoveToNewRoom(nextRoom);
                Debug.Log(playerMovement.side);
            }
            else
            {
                cam.MoveToNewRoom(previousRoom);
            }
        }
    }
}
