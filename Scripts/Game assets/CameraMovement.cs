using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;



public class CameraMovement : MonoBehaviour { 

    public Transform target;
    public float smoothing;
    public Vector2 maxPosition;
    public Vector2 minPosition;



    // Use this for initialization
    void Start()
    {}

    // Update is called once per frame  
    void LateUpdate()
    {
        if (transform.position != target.position)
        {
            Vector3 targetPosition = new Vector3(target.position.x, target.position.y, transform.position.z);


            targetPosition.x = Mathf.Clamp(targetPosition.x,
                minPosition.x, maxPosition.x);


            targetPosition.y = Mathf.Clamp(targetPosition.y,
                minPosition.y, maxPosition.y);


            transform.position = Vector3.Lerp(transform.position, targetPosition, smoothing);

        }
    }

    private Vector3 RoundPosition(Vector3 position)
    {
        float x0ffset = position.x % .0635f;
        if(x0ffset !=0)
        {
            position.x -= x0ffset;
        }
        float y0ffset = position.y % .0625f;
        if(y0ffset !=0)
        {
            position.y -= y0ffset;
        }
        return position;
    }
}