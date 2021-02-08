using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;
    public Vector3 direction;
    public float returnSpeed;
    public bool isReturn;

    public void Update()
    {
        if(isReturn)
        {
            direction.y = direction.y - returnSpeed;
        }

        transform.Translate(direction * speed * Time.deltaTime);
    }

   
}
