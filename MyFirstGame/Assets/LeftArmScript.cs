using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;
using UnityEditor.UI;
using UnityEngine;
using Quaternion = UnityEngine.Quaternion;
using Vector3 = UnityEngine.Vector3;

public class LeftArmScript : MonoBehaviour
{
    //public float xAngle, yAngle, zAngle;
    private float angle = 0;

    //public Material selfMat, worldMat;
    //private float speed=5;
    //float smooth = 5.0f;
    //float tiltAngle = 60.0f;
    float x = 0;


    float smooth = 5.0f;
    float tiltAngle = 60.0f;

    void Start()
    {

        //transform.rotation.x = 0;
    }


    
    // Update is called once per frame
    
    void Update()
    {
       
        //transform.Rotate();
        /*while (true)
        {
            if (x == 180)
                transform.Rotate(Vector3.left, 1, 0);
            if (x == 0)
                transform.Rotate(Vector3.right, 1, 0);
        }*/
    //transform.rotation =Quaternion.Euler(Random.Range(0.0f,180.0f),0f,0f);

    if (transform.eulerAngles.x <= 0 ||transform.eulerAngles.x<=90)
    {
        //transform.Rotate(Vector3.right, 1, 0);
        float degrees = 90;
        Vector3 goUp = new Vector3(degrees, 0, 0);
        transform.eulerAngles = Vector3.Lerp(transform.rotation.eulerAngles, goUp, Time.deltaTime);
    }

    //transform.Rotate(-4,0,0,Space.Self);
    //transform.Rotate(Vector3.right,-1,0);

    else if (transform.eulerAngles.x >=90)// && transform.eulerAngles.x >= 0)
    {
        //transform.Rotate(Vector3.left, 1, 0);
        //transform.Rotate(Vector3.right,1,0);
        float degrees = 0;
        Vector3 goUp = new Vector3(degrees, 0, 0);
        transform.eulerAngles = Vector3.Lerp(transform.rotation.eulerAngles, goUp, Time.deltaTime);
    }
    
    
    //transform.Rotate(4,0,0,Space.Self);

    //transform.eulerAngles = new Vector3(Mathf.Clamp(angle, 0, 180),0,0); //ClampAngle(angle, 0, 180), 0, 0);

    //float degrees = 90;
    //Vector3 goUp = new Vector3(degrees, 0, 0);
    //transform.eulerAngles = Vector3.Lerp(transform.rotation.eulerAngles, goUp, Time.deltaTime);

    //float degrees = 90;
    //Vector3 goDown= new Vector3(degrees, 0, 0);
    //transform.eulerAngles = Vector3.Lerp(transform.rotation.eulerAngles, goDown, Time.deltaTime);
    /*
    if (transform.eulerAngles.x > 180&&Input.GetKey("s"))
    {
        GetComponent<Rigidbody>().angularVelocity=new Vector3(-.5f,0,0);
    }
    else if (transform.eulerAngles.x < 0 && Input.GetKey("w") )
    {
        GetComponent<Rigidbody>().angularVelocity=new Vector3(.5f,0,0);
    }
    */
}

    
}
