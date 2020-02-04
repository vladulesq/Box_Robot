using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class LowerLegScript : MonoBehaviour
{
    // Start is called before the first frame update
    private float angle;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(Vector3.right, Random.Range(0,10),0);
        //transform.Rotate(4,0,0,Space.Self);
        
        
        //transform.eulerAngles = new Vector3(ClampAngle(angle, -90, 0), 0, 0);
        //transform.rotation = Quaternion.Euler(Random.Range(0,-90),0,0);
        
         
        float degrees = 0;
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
