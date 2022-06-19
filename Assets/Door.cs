using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private Transform previousRoom;
    [SerializeField] private Transform nextRoom;
    [SerializeField] private CameraController cam;

    private PlayerMovement playerMovement;
   
    // public int side = 1;
    private void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();
        Debug.Log(playerMovement.side);
    }

      private void Update()
    {
        Debug.Log(playerMovement.side);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (playerMovement.side == 1)
                cam.MoveToNewRoom(nextRoom);
            else
                cam.MoveToNewRoom(previousRoom);
        }
    }
}
