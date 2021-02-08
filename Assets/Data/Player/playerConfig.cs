using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(fileName = "New PlayerConfig", menuName = "player/player config", order = 0)]
public class playerConfig : ScriptableObject
{
    [Serializable]
    public class PowerConfig
    {
        public int powerValue;
        public int cannonAmount;
    }
    public List<PowerConfig> powerConfigs;
    public PowerConfig GetPowerConfig(int powerValue)
    {
        //PowerConfig configToReturn = null;
        foreach(var config in powerConfigs)
        {
            if(config.powerValue >= powerValue)
            {
                return config;
            }
            
        }
        return null;
    }

    
}
