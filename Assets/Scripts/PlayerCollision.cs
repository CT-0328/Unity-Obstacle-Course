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
          FindObjectOfType<Goal>().GoalHit();
        }
        if (collisionInfo.collider.tag == "lastGoal"){
          FindObjectOfType<Goal>().LastLevelGoal();
        }
    }
  }
