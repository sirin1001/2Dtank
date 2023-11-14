using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bullet_b_spwan : MonoBehaviour
{
    [SerializeField] private bullet_b bullet_b;
    [SerializeField] private float spawn_span = 1;
    Coroutine span_coroutine;

    int PastTime = 0;

    void Start()
    {
        
    }

    IEnumerator Spawn()
    {
        while(true)
        {
            var pos = transform.position;
            pos += transform.up * 2;

            GameObject.Instantiate(bullet_b.gameObject, pos, transform.rotation);
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


        var shot = Input.GetButtonDown("Shot1P");
        if (shot && (NowTime - PastTime) > spawn_span)
        {
            span_coroutine = StartCoroutine("Spawn");
            PastTime = NowTime;
        }

        if (Input.GetButtonUp("Shot1P"))
        {
            StopCoroutine(span_coroutine);
        }



    }
}
