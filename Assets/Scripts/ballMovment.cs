using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballMovment : MonoBehaviour
{
    public float dx = 0;
    public float dy = -1f;
    public float speed = 0.2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x + (dx*speed), transform.position.y + (dy*speed), 1);
        if (transform.position.y < GameObject.FindGameObjectWithTag("Player").transform.position.y) {
            Application.LoadLevel(Application.loadedLevel);
        }
    }

    void OnCollisionEnter2D(Collision2D col) {
        if (col.gameObject.tag == "Player") {
            float angle = Random.Range(45f, 135f);
            dx = Mathf.Cos(Mathf.Deg2Rad * angle);
            dy = Mathf.Sin(Mathf.Deg2Rad * angle);
            if (dy < 0) {
                dy *= -1;
            }
        } else if (col.gameObject.tag == "wall_right" || col.gameObject.tag == "wall_left") {
            dx *= -1;
        } else if (col.gameObject.tag == "wall_top") {
            dy *= -1;
        } else if (col.gameObject.tag == "brick" || col.gameObject.tag == "sturdybrick") {
            col.gameObject.GetComponent<brickLife>().life--;
        }
    }
}
