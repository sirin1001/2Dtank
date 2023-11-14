using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bullet_r_spwan : MonoBehaviour
{
    [SerializeField] private bullet_r bullet_r;
    [SerializeField] private float spawn_span = 1;
    Coroutine span_coroutine;

    int PastTime = 0;

    void Start()
    {

    }

    IEnumerator Spawn()
    {
        while (true)
        {
            var pos = transform.position;
            pos += transform.up * 2;

            GameObject.Instantiate(bullet_r.gameObject, pos, transform.rotation);
            yield return new WaitForSeconds(spawn_span);
        }
    }

    // Update is called once per frame
    void Update()
    {

        DateTime getTime = DateTime.Now;
        int NowTime = (getTime.Hour * 360) + (getTime.Minute * 60) + getTime.Second;
        /*
        if(PastTime == 0)
        {
            PastTime = 24 * 360 + 60 * 60 + 60;
        }
        */

        //Debug.Log("N" + NowTime);
        //Debug.Log("P" + PastTime);

        var shot = Input.GetButtonDown("Shot2P");
        if (shot && (NowTime - PastTime) > spawn_span)
        {
            span_coroutine = StartCoroutine("Spawn");
            PastTime = NowTime;
        }

        if (Input.GetButtonUp("Shot2P"))
        {
            StopCoroutine(span_coroutine);
        }



    }
}
