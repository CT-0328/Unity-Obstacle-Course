using UnityEngine;
using UnityEngine.SceneManagement;
//using UnityEngine.UI;

public class Goal : MonoBehaviour {

    public Transform player;
    //public Text winText;

    public void GoalHit() {
      int NextLevel = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(NextLevel);
    }
    public void LastLevelGoal() {
      Debug.Log("You Win!");
    }
}
