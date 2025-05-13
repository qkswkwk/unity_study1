using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerLogic : MonoBehaviour
{
    public int totalItemCount;
    public int stage;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") {
            SceneManager.LoadScene(stage);
        }
    }
}
