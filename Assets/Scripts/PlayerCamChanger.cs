using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamChanger : MonoBehaviour
{
    private GameObject player;
    private Movement movementScript;

    void Start()
    {
        player = GameObject.Find("Player");
        movementScript = player.GetComponent<Movement>();
        movementScript.cam = gameObject.GetComponent<Camera>();
    }
}
