using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MovePlayer : MonoBehaviour
{
    public Transform player;
    public static List<Vector3> path;
    public GameObject targetDot;
    [SerializeField]
    private float speed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        path = new List <Vector3>();
    }


    //
    // Update is called once per frame
    void Update()
    {
       if(path.Count != 0)
        {
            Vector3 mousePosition = (Vector3)path[0];
            float angle = Mathf.Atan2(mousePosition.x - player.position.x, mousePosition.y - player.position.y) * Mathf.Rad2Deg;
            player.rotation = Quaternion.Euler(new Vector3(0, 0, -angle - player.rotation.z));
            player.position = Vector2.MoveTowards(player.position, new Vector2(mousePosition.x, mousePosition.y), speed * Time.deltaTime);
            if((player.position.x == mousePosition.x) && (player.position.y == mousePosition.y))
                path.RemoveAt(0);
        }
    }

    

    private void OnMouseDown()
    {
        if(Time.timeScale != 0f)
            {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Instantiate(targetDot, new Vector3(mousePosition.x, mousePosition.y, 0), Quaternion.identity);
            path.Add(mousePosition);
        }
    }
}
