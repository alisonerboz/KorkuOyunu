using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monsterChase : MonoBehaviour
{
    public Rigidbody monsRigid;
    public Transform monsTrans, PlayTrans;
    public int monSpeed;

    private void FixedUpdate()
    {
        monsRigid.velocity = transform.forward * monSpeed * Time.deltaTime;

    }
    private void Update()
    {
        monsTrans.LookAt(PlayTrans);
    }


}
