using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputKeyBoardListener : MonoBehaviour, iInputable
{
    public void BombPressed()
    {
        InputProvider.TriggerOnHasBomb();
    }

    public void GetDirection(Vector3 direction)
    {
        InputProvider.TriggerDirection(direction);
    }

    public void ShootPressed()
    {
        InputProvider.TriggerOnHasShoot();
    }

    private void Update()
    {
        if(Input.GetButtonDown("Shoot"))
        {
            ShootPressed();
        }

        if(Input.GetButtonDown("Bomb"))
        {
            BombPressed();
        }

        GetDirection(new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), transform.position.z));
    }



}
