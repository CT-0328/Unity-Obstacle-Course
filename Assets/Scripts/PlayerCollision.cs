using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement movement;

    // Update is called once per frame
    void OnCollisionEnter(Collision collisionInfo) {
        if (collisionInfo.collider.tag == "Obstacle") {
          movement.enabled = false;
          FindObjectOfType<GameManager>().GameOver();
        }
        if (collisionInfo.collider.tag == "goal"){
          movement.enabled = false;
          FindObjectOfType<Goal>().GoalHit();
        }
        if (collisionInfo.collider.tag == "lastGoal"){
          movement.enabled = false;
          FindObjectOfType<Goal>().LastLevelGoal();
        }
      }
      void OnCollisionStay(Collision collisionInfo) {
        if (collisionInfo.collider.tag == "Platform") {
          FindObjectOfType<PlayerMovement>().canJump();
          Debug.Log("Platform!!!!!");
        }
        if (collisionInfo.collider.tag == "Ground") {
          FindObjectOfType<PlayerMovement>().canJump();
          Debug.Log("Ground!!!!!");
        }
      }

  }
