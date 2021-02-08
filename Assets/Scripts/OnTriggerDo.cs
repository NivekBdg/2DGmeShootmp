using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnTriggerDo : MonoBehaviour
{
    [SerializeField] private UnityEvent action;

    protected GameObject collisionee;

    private void OnTriggerEnter2D(Collider2D collision)
    {

        collisionee = collision.gameObject;
        Debug.LogFormat("Saving Collisionee {0}", collisionee);
        action.Invoke();
    }

    public void DestroyCollisionee()
    {
        Debug.LogFormat("Collisionee is {0}", collisionee);
        if (collisionee != null)
        {
            Destroy(collisionee);
        }
    }
}
