
using UnityEngine;

public interface iInputable
{
    void ShootPressed();
    void BombPressed();
    //void GetHorizontalAxis(float value);
    //void GetVerticalAxis(float value);
    void GetDirection(Vector3 direction);
}
