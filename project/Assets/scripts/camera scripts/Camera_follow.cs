using UnityEngine;

public class Camera_follow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    [Range(1,10)]
    public float smoothFactor;
    public Vector3 minValue, maxValue;
    private void FixedUpdate()
    {
        follow();
    }
    void follow()
    {


        // follow 
        Vector3 targetPosition = target.position + offset;
        //verify if out of bound or not
        Vector3 boundsPosition = new Vector3(
             Mathf.Clamp(targetPosition.x,minValue.x, maxValue.x), 
             Mathf.Clamp(targetPosition.y,minValue.y, maxValue.y), 
             Mathf.Clamp(targetPosition.z,minValue.z, maxValue.z));


        Vector3 smoothPosition = Vector3.Lerp(transform.position,boundsPosition,smoothFactor*Time.fixedDeltaTime);
        transform.position = smoothPosition;

    }
}
 