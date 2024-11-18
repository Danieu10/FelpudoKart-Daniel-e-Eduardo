using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroiInimigos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "fim")
        {
            Destroy(this.gameObject);
        }
    }
}
