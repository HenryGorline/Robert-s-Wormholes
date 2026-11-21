using UnityEngine;
using UnityEngine.SceneManagement;
public class TitleScreen : MonoBehaviour
{

    public void OnClickPlay()
    {
        SceneManager.LoadScene(1);
    }
    public void OnClickQuit()
    {
        Application.Quit();
    }
}
