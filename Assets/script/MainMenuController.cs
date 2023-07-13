using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public InputField usernameInput;
    public Button playButton;

    private void Start()
    {
        playButton.interactable = false;
    }

    public void OnUsernameChanged()
    {
        playButton.interactable = !string.IsNullOrEmpty(usernameInput.text);
    }

    public void OnPlayButtonClicked()
    {
        string username = usernameInput.text;
        if (!string.IsNullOrEmpty(username))
        {
            PlayerPrefs.SetString("Username", username); 
            SceneManager.LoadScene(1); 
        }
    }
}
