using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour
{

    public Vector3 dir;
    public float speed = 20f;
    public int damage=20;
    // Update is called once per frame
    void Update()
    {
        transform.position += (dir * speed*Time.deltaTime);
    }
}
