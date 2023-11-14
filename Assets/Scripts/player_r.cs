using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player_r : MonoBehaviour
{
    [SerializeField] private float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        var pos = transform.position;
        pos.x = 6;
        pos.y = 0;
        pos.z = 0;

        transform.position = pos;

    }

    // Update is called once per frame
    void Update()
    {
        var pos = transform.position;
        var rot = transform.rotation;
        var Raxis = Input.GetAxis("Horizontal2P");
        var Paxis = Input.GetAxis("Vertical2P");
        //pos.x += axis * speed * Time.deltaTime;

        transform.Rotate(new Vector3(0, 0, 180) * Raxis * Time.deltaTime * -1);
        transform.position -= transform.up * speed * Paxis * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.R))
        {
            this.gameObject.SetActive(true);
        }

        //transform.position = pos;
        //transform.rotation = rot;
    }
}
