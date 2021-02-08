using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyConfig", menuName = "Enemies/Enemy config", order = 0)]
public class EnemyConfig : ScriptableObject
{
    public float moverSpeed;
    public Sprite EnemySprite;
    public bool isShooter;
    public bool isLaser;
    public float shootCadence;
    public float shootInitialTime;
    public Vector3 moverDirection;
    public float moverSpeedReturn;
    public bool moverIsReturn;
    public int score;
}
