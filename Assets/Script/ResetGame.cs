using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetGame : MonoBehaviour
{
    public void ResetGame1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
