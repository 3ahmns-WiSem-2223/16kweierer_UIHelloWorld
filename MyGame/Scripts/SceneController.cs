using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
   
    public void OnNextButtonClick()
    {
        SceneManager.LoadScene(1);
    }

    public void OnBackBUttonClick()
    {
        SceneManager.LoadScene(0);
    }
}
