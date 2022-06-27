using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject door_closed, door_opened, intText, lockedtext;
    public AudioSource open, close;
    public bool opened, locked,locked2=true;
    public static bool keyfound;


    void start()
    {
        keyfound = false;
    }
    void Update()
    {
        //Debug.Log(locked);
        if (keyfound == true)
        {
            Debug.Log("++");
        }
    }

    public void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            if (opened == false)
            {
                if (locked2 == false)
                {
                    intText.SetActive(true);
                    if (Input.GetKeyUp(KeyCode.E))
                    {
                        door_closed.SetActive(false);
                        door_opened.SetActive(true);
                        intText.SetActive(false);
                        StartCoroutine(repeat());
                        opened = true;

                    }
                }
                if (locked2 == true)
                {
                    lockedtext.SetActive(true);
                }
            }
        }
    }

 
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            intText.SetActive(false);
            lockedtext.SetActive(false);

        }
    }

    IEnumerator repeat()
    {
        yield return new WaitForSeconds(3.0f);
        opened = false;
        door_closed.SetActive(true);
        door_opened.SetActive(false);
    }
    

    public void anahtarbuldukmk()
    {
        Debug.Log("açýl mk");
        locked2 = false;
        keyfound = true;
        
    }

}
