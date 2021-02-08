using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController instance;
    private int score;
    [SerializeField] private PlayerController player;
    private int powerLevel;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Awake()
    {
        instance = this;
    }

    public void OnDie(GameObject deadObject, int getScore = 0)
    {
        score += getScore;
        Debug.LogFormat("Gamecontroller: " + deadObject.name + " Score: " + score);
        
    }
}
