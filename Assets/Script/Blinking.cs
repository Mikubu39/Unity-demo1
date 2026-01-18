using UnityEngine;

public class Blinking : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        // Lấy component SpriteRenderer để điều khiển hình ảnh
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        // Đảo ngược trạng thái bật/tắt liên tục
        spriteRenderer.enabled = !spriteRenderer.enabled;
    }
}