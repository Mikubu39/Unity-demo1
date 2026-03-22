using UnityEngine;

 public class FlyPathAgent : MonoBehaviour
{
 public FlyPath flyPath; 
   public float flySpeed; 
   private int nextIndex = 1; 

    // Khởi tạo vị trí ban đầu tại waypoint số 0
    //void Start() => transform.position = flyPath[0]; 

    void Update()
    {
     if (flyPath == null) return; 

        // Hủy object nếu đã bay qua hết tất cả các điểm waypoint
   if (nextIndex >= flyPath.waypoints.Length) 
        {
             Destroy(gameObject); 
           return; 
        }

        // Nếu chưa tới điểm tiếp theo, tiếp tục bay
       if (transform.position != flyPath[nextIndex]) 
        {
            FlyToNextWaypoint(); 
             LookAt(flyPath[nextIndex]); 
        }
        else
        {
            nextIndex++; // Chuyển sang điểm waypoint kế tiếp [cite: 149]
        }
    }

 private void FlyToNextWaypoint() 
        => transform.position = Vector3.MoveTowards(transform.position, flyPath[nextIndex], flySpeed * Time.deltaTime); 

    // Hàm toán học giúp Enemy xoay đầu theo hướng đang di chuyển
 private void LookAt(Vector2 destination) 
    {
        Vector2 position = transform.position; 
       var lookDirection = destination - position; 
         if (lookDirection.magnitude < 0.01f) return; 
         var angle = Vector2.SignedAngle(Vector3.down, lookDirection); 
         transform.rotation = Quaternion.Euler(0, 0, angle); 
    }
}