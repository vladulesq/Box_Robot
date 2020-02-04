using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;

public class HeadScript : MonoBehaviour
{
    // Start is called before the first frame update
    private float angle=0;
    
    
    void Start()
    {
        //head = GameObject.Find("Head");
    }

    // Update is called once per frame
    void Update()
    {
        transform.eulerAngles = new Vector3(0, ClampAngle(angle, -45, 45), 0);

        //head.transform.Rotate(0,10*Time.deltaTime,0);
        //if(head.GetComponent(Xangle))
        //transform.Rotate(Vector3.up, Random.Range(-45,45),0);
        //transform.rotation = Quaternion.Euler(0,Random.Range(-45,45),0);
    }
    
    protected float ClampAngle(float angle, float min, float max) {
 
        angle = NormalizeAngle(angle);
        if (angle > 180) {
            angle -= 360;
        } else if (angle < -180) {
            angle += 360;
        }
 
        min = NormalizeAngle(min);
        if (min > 180) {
            min -= 360;
        } else if (min < -180) {
            min += 360;
        }
 
        max = NormalizeAngle(max);
        if (max > 180) {
            max -= 360;
        } else if (max < -180) {
            max += 360;
        }
 
        // Aim is, convert angles to -180 until 180.
        return Mathf.Clamp(angle, min, max);
    }
 
    /** If angles over 360 or under 360 degree, then normalize them.
     */
    protected float NormalizeAngle(float angle) {
        while (angle > 360)
            angle -= 360;
        while (angle < 0)
            angle += 360;
        return angle;
    }

}
