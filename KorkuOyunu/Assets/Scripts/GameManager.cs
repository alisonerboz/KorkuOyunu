using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject isik;
    public GameObject yesil;
    public GameObject kirmizi;
    bool isikDurum=false;
    bool feneralindi = false;
    AudioSource ses;
    public GameObject fenercigim;
    void Start()
    {
        isik.SetActive(false);
        yesil.SetActive(true);
        kirmizi.SetActive(false);
        ses =fenercigim.GetComponent<AudioSource>();
    }

    
    void Update()
    {
        if(Input.GetButtonUp("Fire2") && isikDurum==false&& feneralindi == true)
        {
            StartCoroutine(isikAc());
        }
        if(Input.GetButtonUp("Fire2") && isikDurum == true&& feneralindi == true)
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
        kirmizi.SetActive(true);
        yesil.SetActive(false);
        ses.Play();

    }
    IEnumerator isikKapa()
    {
        yield return new WaitForSeconds(0.2f);
        Debug.Log("kapa" + isikDurum);
        isik.SetActive(false);
        isikDurum = false;
        yesil.SetActive(true);
        kirmizi.SetActive(false);
        ses.Play();

    }
    public void feneraldi()
    {
        feneralindi = true;
    }
}
