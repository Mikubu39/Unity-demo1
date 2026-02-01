using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class PlayerMovement : MonoBehaviour
{
    void Update()
    {
        // 1. Lấy vị trí chuột trên màn hình và chuyển đổi sang tọa độ thế giới game (World Point)
        var worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        worldPoint.z = 10;
        // 2. Đặt lại trục Z = 0 để đảm bảo tàu vẫn nằm trên mặt phẳng 2D
        Vector3 spawnPosition = transform.position;
        if (worldPoint.y > 3)
        {
            worldPoint.y = 3;
        }

        // 3. Gán vị trí mới cho tàu
        transform.position = worldPoint;
    }
}