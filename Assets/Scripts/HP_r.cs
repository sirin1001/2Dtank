using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HP_r : MonoBehaviour
{
    private Slider slider;
    private float MAXHP = 3;
    private int HP;
    private Collider2D collider2D;
    private Rigidbody2D rigidbody2D;
    private Collider2D trigger;
    // Start is called before the first frame update
    void Start()
    {
        slider = GameObject.Find("HP_R").GetComponent<Slider>();
        HP = (int)MAXHP;
        slider.value = 1;

        collider2D = GetComponent<Collider2D>();
        rigidbody2D = GetComponent<Rigidbody2D>();
        trigger = GetComponent<Collider2D>();
    }
    void RecvDamage(int attack)
    {
        HP -= attack;
        slider.value = HP / MAXHP;
    }
    /*void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("ÉRÉäÉWÉáÉìê⁄êGÇ†ÇË");
        if (collision.gameObject.tag == "red_bullet")
        {
            
            this.RecvDamage(1);
        }
    }
    */

    void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("R_ÉgÉäÉKÅ[ê⁄êGÇ†ÇË");
        if (collider.gameObject.tag == "blue_bullet")
        {

            this.RecvDamage(1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        var scl = transform.localScale;

        if (Input.GetKeyDown(KeyCode.J))
        {
            this.RecvDamage(1);
        }

        if (HP <= 0 && scl.x >= 0)
        {
            scl.x -= (float)0.1;
            scl.y -= (float)0.1;
            transform.localScale = scl;
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            HP = (int)MAXHP;
        }
    }
}
