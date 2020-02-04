using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForeArmScript : MonoBehaviour
{
    // Start is called before the first frame update
    private float angle;
    

    /*
    private float rotationanglex1;
    private float rotationanglex2;
    private float rotationangley1;
    private float rotationangley2;
    void Update () {
        rotationanglex1 = transform.eulerAngles.x;
        rotationanglex2 = transform.eulerAngles.x;
        rotationangley1 = transform.eulerAngles.y;
        rotationangley2 = transform.eulerAngles.y;
       
        if (rotationanglex1 > 320 && rotationanglex1 < 330) {
            Debug.Log("Hello X1");
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler (10, transform.eulerAngles.y, transform.eulerAngles.z),
            Time.deltaTime * 1.5f);
        }
        if (rotationanglex2 > 100 && rotationanglex2 < 110) {
            Debug.Log("Hello X2");
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler (-10, transform.eulerAngles.y, transform.eulerAngles.z),
            Time.deltaTime * 1.5f);
            
        }
        
        if (rotationangley1 > 330 && rotationangley1 < 340) {
            Debug.Log("Hello Y2");
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler (transform.eulerAngles.x, 10, transform.eulerAngles.z),
            Time.deltaTime * 1.5f);
        }
        if (rotationangley2 > 30 && rotationangley2 < 40) {
            Debug.Log("Hello Y2");
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler (transform.eulerAngles.x, -10, transform.eulerAngles.z),

            Time.deltaTime * 1.5f);
        }
    }
    
    */
    // Update is called once per frame
    
    void Update()
    {
        
        //float degrees = 100;
        //Vector3 goUp = new Vector3(degrees, 0, 0);
        //transform.eulerAngles = Vector3.Lerp(transform.rotation.eulerAngles, goUp, Time.deltaTime);
        
        
        /*
        if (transform.eulerAngles.x<=0)
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
        */
        //transform.eulerAngles = new Vector3(ClampAngle(angle, 0, 90), 0, 0);
        //transform.Rotate(Vector3.right, Random.Range(0,10),0);
        //transform.Rotate(4,0,0,Space.Self);
        
        //transform.rotation = Quaternion.Euler(Random.Range(180f,270f),0f,0f);
        
        float degrees = 90;
        Vector3 goUp = new Vector3(degrees, 0, 0);
        transform.eulerAngles = Vector3.Lerp(transform.rotation.eulerAngles, goUp, Time.deltaTime);
        
        
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
