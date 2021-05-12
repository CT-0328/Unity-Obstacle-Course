using UnityEngine;

public class PlayerMovement : MonoBehaviour {

  public Rigidbody rb;
  public int forwardSpeed;
  public int sidewaysSpeed;
  public int upwardSpeed;

    // FixedUpdate is better for physics stuff
    void FixedUpdate() {
      rb.AddForce(0, 0, forwardSpeed * Time.deltaTime);

      if (Input.GetKey("d")) {
        rb.AddForce(sidewaysSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
      }
      if (Input.GetKey("a")) {
        rb.AddForce(-sidewaysSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
      }
      if (Input.GetKey("space")) {
        rb.AddForce(0, upwardSpeed * Time.deltaTime, 0, ForceMode.VelocityChange);
      }


      if (rb.position.y < -1) {
        FindObjectOfType<GameManager>().GameOver();
      }
    }
}
