using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kapi : MonoBehaviour
{
    public GameObject door_closed, door_opened,intText;
    
    bool opened=false;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    public void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            if (opened == false)
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
        }
    }
    IEnumerator repeat()
    {
        yield return new WaitForSeconds(3.0f);
        opened = false;
        door_closed.SetActive(true);
        door_opened.SetActive(false);
    }
}
