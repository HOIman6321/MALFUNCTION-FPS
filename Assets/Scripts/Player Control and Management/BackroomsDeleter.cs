using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackroomsDeleter : MonoBehaviour
{
    public BackroomsGenerator gen;

    void Awake()
    {
        gen = GameObject.Find("Backrooms Generator").GetComponent<BackroomsGenerator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(gen.player.position, transform.position) > 100f)
        {
            gen.values.Remove(transform.position.x.ToString() + " " + transform.position.z.ToString());
            Destroy(gameObject);
        }
    }
}