using UnityEngine;

public class ObstacleMove : MonoBehaviour {

  public Rigidbody rb;
  public int obstacleSpeed;
  public float interval;
  private float timeTracker = 0;

    void Update() {
      if (Time.time > timeTracker) {
        timeTracker = Time.time + interval;
        obstacleSpeed = obstacleSpeed * -1;
      }
      rb.AddForce(obstacleSpeed * Time.deltaTime, 0, 0);
    }
}
