using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEditor;
using UnityEngine;

public class bullet_b : MonoBehaviour
{
    // Start is called before the first frame update
    private SpriteRenderer sprite;
    [SerializeField] private float speed = 20f;
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!sprite.isVisible)
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
