using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballon : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed = 0.2f;
    private Vector2 screenBounds;
    private Rigidbody2D rb;
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(UnityEngine.Random.Range(-1, 1), 0);
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width,Screen.height,Camera.main.transform.position.z));
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y > screenBounds.y*1.4)
        {
            Destroy(this.gameObject);
        }
    }
}
