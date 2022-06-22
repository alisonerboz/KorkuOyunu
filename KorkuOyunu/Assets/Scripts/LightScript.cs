using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour
{
    public GameObject flashligt_ground, inticon, flashlight_player;

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            inticon.SetActive(true);
            if (Input.GetKeyUp(KeyCode.E))
            {
                flashligt_ground.SetActive(false);
                inticon.SetActive(false);
                flashlight_player.SetActive(true);
            }
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            inticon.SetActive(false);
        }
    }
}
