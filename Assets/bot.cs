using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bot: MonoBehaviour
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
        if (Input.GetKey("i"))
        {
            transform.Translate(Vector3.left * Time.deltaTime * Speed, Space.Self);
            angle_det();
        }

        if (Input.GetKey("k"))
        {
            transform.Translate(Vector3.left * Time.deltaTime * -Speed, Space.Self);
            angle_det();
        }

        if (Input.GetKey("j"))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * -Speed, Space.Self);
            angle_det();
        }

        if (Input.GetKey("l"))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * Speed, Space.Self);
            angle_det();
        }
        if (Input.GetKey("u"))
        {
            transform.Rotate(Vector3.up * Time.deltaTime * -Speed, Space.Self);
            angle_det();
        }

        if (Input.GetKey("o"))
        {
            transform.Rotate(Vector3.up * Time.deltaTime * Speed, Space.Self);
            angle_det();
        }

    }
void angle_det()
    {
        
        main_x.text = "Main X" + (int)System.Math.Ceiling(transform.eulerAngles.x);
        main_y.text = "Main Y" + (int)System.Math.Ceiling(transform.eulerAngles.y);
        main_z.text = "Main Z" + (int)System.Math.Ceiling(transform.eulerAngles.z);
    }
}
