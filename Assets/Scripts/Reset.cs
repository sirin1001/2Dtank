using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Reset : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            var ObjNm = this.gameObject.name;
            var pos = transform.position;
            var rot = transform.rotation;
            var scl = transform.localScale;
            Slider slider;

            switch (ObjNm)
            {
                case "blue_tank_00":
                    Debug.Log("blue_tank_00をリセット");
                    pos.x = -6;
                    pos.y = 0;
                    pos.z = 0;

                    rot.x = 0;
                    rot.y = 0;
                    rot.z = 0;

                    scl.x = 6;
                    scl.y = 6;
                    scl.z = 1;
                    break;
                case "red_tank_00":
                    Debug.Log("red_tank_00をリセット");
                    pos.x = 6;
                    pos.y = 0;
                    pos.z = 0;

                    rot.x = 0;
                    rot.y = 0;
                    rot.z = 90;

                    scl.x = 6;
                    scl.y = 6;
                    scl.z = 1;
                    break;
                case "HP_B":
                    slider = GameObject.Find("HP_B").GetComponent<Slider>();
                    slider.value = 1;
                    break;
                case "HP_R":
                    slider = GameObject.Find("HP_R").GetComponent<Slider>();
                    slider.value = 1;
                    break;
                case "ロゴ":
                    scl.x = (float)3.7;
                    scl.y = (float)3.7;
                    break;
            }
            transform.position = pos;
            transform.rotation = rot;
            transform.localScale = scl;

        }

    }

}
