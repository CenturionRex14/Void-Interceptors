using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShip : MonoBehaviour
{
    public Transform playerShipTransform;

    private float moveDelta = 0.1F;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        updatePlayerPosition();
    }

    private void updatePlayerPosition()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            //playerShip.GetComponent("Transform");
            playerShipTransform.position += Vector3.up * moveDelta;
        }else if (Input.GetKeyDown(KeyCode.S))
        {
            playerShipTransform.position += Vector3.down * moveDelta;
        }else if (Input.GetKeyDown(KeyCode.D))
        {
            playerShipTransform.position += Vector3.right * moveDelta;
        }else if (Input.GetKeyDown(KeyCode.A))
        {
            playerShipTransform.position += Vector3.left * moveDelta;
        }
    }
}
