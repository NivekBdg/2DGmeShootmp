using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnEnemyTriggerEnterDo : MonoBehaviour
{
    [SerializeField] private UnityEvent alwaysAction;
    [SerializeField] private UnityEvent UningonerAction;
    [SerializeField] List<string> tagsToIgnore;

    private void OnTriggerEnter2D(Collider2D collision)
    {

        alwaysAction.Invoke();
        foreach (var ingoretag in tagsToIgnore)
        {
            if(collision.tag == ingoretag)
            {
                return;
            }
        }

        UningonerAction.Invoke();
    }
}
