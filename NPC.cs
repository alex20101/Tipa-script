using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public int health = 1;
    public float speed = 1.2f;
    public int level = 1;

    
    // Start is called before the first frame update
    void Start()
    {
        health += level;
        print(health + "Çהמנמגüו ÍÏÑ");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
