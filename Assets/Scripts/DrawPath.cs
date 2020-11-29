using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawPath : MonoBehaviour
{
    public GameObject dot;
    public Transform player;
    [SerializeField]
    private float speed = 0.3f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DrawingPath());        
    }

    IEnumerator DrawingPath()
    {
        while (true)
        {
            Instantiate(dot, new Vector3(player.position.x, player.position.y, 0), Quaternion.identity);
            yield return new WaitForSeconds(speed);
        }
    }
}
