using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyScript : MonoBehaviour
{
    public GameObject inticon, key,sign1,sign2;
    Door door;
    KitliKapi kitli;

    void Start()
    {
        door= FindObjectOfType<Door>();
        kitli = FindObjectOfType<KitliKapi>();
    }
    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            inticon.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                key.SetActive(false);
                //Door.keyfound = true;
                //door.anahtarbuldukmk();
                kitli.ac();
                inticon.SetActive(false);
                sign1.SetActive(true);
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
