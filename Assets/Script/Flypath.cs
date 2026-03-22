using UnityEngine;

public class FlyPath : MonoBehaviour
{
    public Waypoint[] waypoints; // Bạn đã làm bước này ở Part 7

    // Thêm Indexer để trả về vị trí của waypoint theo index
     public Vector3 this[int index] => waypoints[index].transform.position; 

    // Vẽ đường nối các waypoint trong cửa sổ Scene
     private void OnDrawGizmos() 
    {
       if (waypoints == null) return; 
     Gizmos.color = Color.green; 
 for (int i = 0; i<waypoints.Length - 1; i++) 
        {
             Gizmos.DrawLine(waypoints[i].transform.position, waypoints[i + 1].transform.position); 
}
    }
}