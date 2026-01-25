using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    void Update()
    {
        // 1. Lấy vị trí chuột trên màn hình và chuyển đổi sang tọa độ thế giới game (World Point)
        var worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // 2. Đặt lại trục Z = 0 để đảm bảo tàu vẫn nằm trên mặt phẳng 2D
        worldPoint.z = 10;

        // 3. Gán vị trí mới cho tàu
        transform.position = worldPoint;
    }
}