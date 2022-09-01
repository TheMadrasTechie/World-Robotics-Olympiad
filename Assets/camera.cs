using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class camera : MonoBehaviour
{

    public float Speed;

    public Text main_x;
    public Text main_y;
    public Text main_z;
    public Text aim_x;
    public Text aim_y;
    public Text aim_z;
    void Start()
    {

    }
    
    void Update()
    {
        angle_dir();
        if (Input.GetKey("x"))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * Speed, Space.Self);
            angle_dir();
        }

        if (Input.GetKey("c"))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * -Speed, Space.Self);
            angle_dir();
        }
        if (Input.GetKey("q"))
        {
            transform.Rotate(Vector3.forward * Time.deltaTime * Speed, Space.Self);
            angle_dir();
        }
        if (Input.GetKey("e"))
        {
            transform.Rotate(Vector3.forward * Time.deltaTime * -Speed, Space.Self);
            angle_dir();
        }
        if (Input.GetKey("w"))
        {
            transform.Rotate(Vector3.left * Time.deltaTime * Speed, Space.Self);
            angle_dir();
        }
        
        if (Input.GetKey("s"))
        {
            transform.Rotate(Vector3.right * Time.deltaTime * Speed, Space.Self);

            angle_dir();
        }

        if (Input.GetKey("a"))
        {
            transform.Rotate(Vector3.down * Time.deltaTime * Speed, Space.Self);
            angle_dir();
        }

        if (Input.GetKey("d"))
        {
            transform.Rotate(Vector3.up * Time.deltaTime * Speed, Space.Self);
            angle_dir();
        }
        
    }
void angle_dir()
    {
        aim_x.text = "arm X" + (int)System.Math.Ceiling(transform.eulerAngles.x);
        aim_y.text = "arm Y" + (int)System.Math.Ceiling(transform.eulerAngles.y);
        aim_z.text = "arm Z" + (int)System.Math.Ceiling(transform.eulerAngles.z);
    }
}
