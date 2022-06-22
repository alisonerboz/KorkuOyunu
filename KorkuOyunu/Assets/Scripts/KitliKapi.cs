using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitliKapi : MonoBehaviour
{
    public GameObject door_closed, door_opened, intText, lockedtext;
    public bool kitliyim = true;
    public bool opened;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.T))
        {
            kitliyim = false;
        }
        Debug.Log(kitliyim);
    }

    public void ac()
    {
        kitliyim = false;
    }
    public void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                intText.SetActive(true);
                if (kitliyim==false)
                {
                    door_closed.SetActive(false);
                    door_opened.SetActive(true);
                    intText.SetActive(false);
                    //gameObject.SetActive(false);
                    StartCoroutine(repeat());
                    opened = true;


                }
                if (kitliyim == true)
                {
                    lockedtext.SetActive(true);
                    StartCoroutine(yazisil());

                }
            }
        }
    }

    IEnumerator yazisil()
    {
        yield return new WaitForSeconds(3.0f);
        lockedtext.SetActive(false);

    }
    IEnumerator repeat()
    {
        yield return new WaitForSeconds(3.0f);
        opened = false;
        door_closed.SetActive(true);
        door_opened.SetActive(false);
        lockedtext.SetActive(false);

    }

}
    



