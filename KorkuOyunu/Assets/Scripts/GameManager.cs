using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject isik;
    bool isikDurum=false;

    AudioSource ses;
    void Start()
    {
        isik.SetActive(false);
        ses = GetComponent<AudioSource>();
    }

    
    void Update()
    {
        if(Input.GetButtonUp("Fire2") && isikDurum==false)
        {
            StartCoroutine(isikAc());
        }
        if(Input.GetButtonUp("Fire2") && isikDurum == true)
        {
            StartCoroutine(isikKapa());
        }
        if(Input.GetKey(KeyCode.W)|| Input.GetKey(KeyCode.A)|| Input.GetKey(KeyCode.S)|| Input.GetKey(KeyCode.D))
        {
            //ses.Play();
        }
        //else
    }
    IEnumerator isikAc()
    {
        yield return new WaitForSeconds(0.2f);
        Debug.Log("ac"+isikDurum);
        isik.SetActive(true);
        isikDurum = true;
    }
    IEnumerator isikKapa()
    {
        yield return new WaitForSeconds(0.2f);
        Debug.Log("kapa" + isikDurum);
        isik.SetActive(false);
        isikDurum = false;
    }
}
