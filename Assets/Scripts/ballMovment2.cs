using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballMovment2 : MonoBehaviour
{
    public Rigidbody2D rb;
    public float yforce = 15f;
    public float xforce = 0f;
    // Start is called before the first frame update
    void Start()
    {
        xforce = Random.Range(-20f, 20f);
        rb.AddForce(new Vector3(xforce, yforce, 0));
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < GameObject.FindGameObjectWithTag("Player").transform.position.y) {
            Application.LoadLevel(Application.loadedLevel);
        }
    }

    void OnCollisionEnter2D(Collision2D col) {
        if (col.gameObject.tag == "brick" || col.gameObject.tag == "sturdybrick") {
            col.gameObject.GetComponent<brickLife>().life--;
        }
    }
}
