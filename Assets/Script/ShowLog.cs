using UnityEngine;

public class ShowLog : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Hello World!"); // Chỉ hiện 1 lần khi bắt đầu
    }
    void Update()
    {
        Debug.Log("Update called! " + Time.frameCount); // Hiện liên tục
    }
}