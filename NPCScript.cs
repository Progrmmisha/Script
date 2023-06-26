using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCScript : MonoBehaviour
{
    public float health = 10f;
    public int level = 1;
    public float add_health = 1f;
    private float move = 132f;
    private bool left = false;
    private bool right = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (move < 150 && right)
        {
            move += Time.deltaTime;
            transform.position = new Vector3(move, 15, 43);
            
        }
        else
        {
            left = true;
            right = false;
        }
        if (move > 132 && left)
        {
            move -= Time.deltaTime;
            transform.position = new Vector3(move, 15, 43);
        }
        else
        {
            left = false;
            right = true;
        }
    }
}
