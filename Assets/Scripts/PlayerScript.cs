using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Target")
        {

            if((MovePlayer.path[0].x == collision.gameObject.transform.position.x) && (MovePlayer.path[0].y == collision.gameObject.transform.position.y))
                Destroy(collision.gameObject);
        }
    }
}
