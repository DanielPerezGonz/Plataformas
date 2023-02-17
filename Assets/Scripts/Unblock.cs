using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unblock : MonoBehaviour
{
    public bool dash = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Dash")
        {
            Destroy(collision.gameObject);
            dash = true;
        }
        if (collision.gameObject.tag == "TwoJumps")
        {
            Destroy(collision.gameObject);
            GetComponent<Jump>().numJumps++;
        }
    }
}
