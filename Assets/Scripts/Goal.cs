using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
//using UnityEngine.UI;

public class Goal : MonoBehaviour {
    public Text winText;
    public Transform player;
    //public Text winText;

    public void GoalHit() {
      int NextLevel = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(NextLevel);
    }
    public void LastLevelGoal() {
      winText.text = "You Win!";
    }
}
