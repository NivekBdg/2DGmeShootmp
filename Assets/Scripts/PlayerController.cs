using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class Boundary
{
    public float xMinimum, xMaximum, yMinimum, yMaximum;
}

public class PlayerController : MonoBehaviour
{
    public Move moverComponent;
    public float speed;
    public Boundary boundary;
    [SerializeField] private List<Shooter> shooter;
    [SerializeField] private List<playerConfig> playerConf;
    public GameObject bombPrefab;
    
    private void Awake()
    {

    }

    private void OnEnable()
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        moverComponent.speed = speed;
        InputProvider.OnHasShoot += OnHasShoot;
        InputProvider.OnDirection += OnDirection;
        InputProvider.OnHasBomb += OnHasBomb;
    }

    private void OnHasBomb()
    {
        //foreach (var shoot in shooter)
        //{

        //    shoot.DoShoot();
        //}
    }

    private void OnDirection(Vector3 direction)
    {
        moverComponent.direction = direction;
    }

    private void OnHasShoot()
    {
        foreach(var shoot in shooter)
        {
            shoot.DoShoot();
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Mathf.Clamp(transform.position.x, boundary.xMinimum, boundary.xMaximum);
        float y = Mathf.Clamp(transform.position.y, boundary.yMinimum, boundary.yMaximum);
        transform.position = new Vector3(x, y);
       
    }

    private void OnDisable()
    {

    }

    private void OnDestroy()
    {

    }
}
