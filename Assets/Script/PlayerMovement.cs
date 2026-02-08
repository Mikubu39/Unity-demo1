using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class PlayerMovement : MonoBehaviour
{
    void Update()
    {
   
        var worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        worldPoint.z = 10;

        Vector3 spawnPosition = transform.position;
        if (worldPoint.y > 3)
        {
            worldPoint.y = 3;
        }
        transform.position = worldPoint;
    }
}