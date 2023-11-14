using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEditor;
using UnityEngine;

public class bullet_r : MonoBehaviour
{
    // Start is called before the first frame update
    private SpriteRenderer sprite;
    [SerializeField] private float speed = 20f;
    private Collider2D collider2D;
    private Collider2D trigger;
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        collider2D = GetComponent<Collider2D>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        if (!sprite.isVisible)
        {
            Destroy(gameObject);
        }

        Move();



    }

    void Move()
    {
        transform.position += transform.up * speed * Time.deltaTime;
    }
}
