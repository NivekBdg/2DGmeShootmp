using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [HideInInspector]
    public EnemyConfig config;
    [SerializeField] private SpriteRenderer spriteRenderer;
    private Shooter[] shooters;
    private Move mover;

    private void Start()
    {
        mover = GetComponent<Move>();
        if(mover != null)
        {
            mover.speed = config.moverSpeed;
            mover.direction = config.moverDirection;
            mover.isReturn = config.moverIsReturn;
            mover.returnSpeed = config.moverSpeedReturn;
        }

        if(config.EnemySprite != null)
        {
            spriteRenderer.sprite = config.EnemySprite;
        }

        if(config.isShooter)
        {
            shooters = GetComponentsInChildren<Shooter>();
            if(shooters != null && shooters.Length > 0)
            {
                StartCoroutine(ShootForever());
            }
        }
    }

    public void OnDie()
    {
        Debug.Log("Hey!");
        GameController.instance.OnDie(gameObject, config.score);
    }

    private IEnumerator ShootForever()
    {
        yield return new WaitForSeconds(config.shootInitialTime);
        while(true)
        {
            foreach (var shooter in shooters)
            {
                if(config.isLaser)
                {
                    shooter.DoLaser();
                }
                else
                {
                    shooter.DoShoot();
                }
            }
            yield return new WaitForSeconds(config.shootCadence);
        }
    }
}
