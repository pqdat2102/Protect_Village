using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PopupGameOver : MonoBehaviour
{
    [SerializeField] private Button replayButton;
    [SerializeField] private Button quitButton;


    private void Start()
    {
        replayButton.onClick.AddListener(ReplayGame);
        quitButton.onClick.AddListener(QuitGame);
    }

    public void ShowPopup()
    {
        gameObject.SetActive(true);
    }

    public void HidePopup()
    {
        gameObject.SetActive(false);
    }

    private void ReplayGame()
    {
        GameplayManager.Ins.RestartGame();
        HidePopup();
    }

    private void QuitGame()
    {
        HidePopup();
    }
}
