using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Метод для кнопки "Новая игра"
    public void StartNewGame()
    {
        // Переход на сцену геймплея
        SceneManager.LoadScene("GameplayScene");
    }

    // Метод для кнопки "О программе"
    public void OpenAbout()
    {
        // Переход на сцену с описанием программы
        SceneManager.LoadScene("AboutScene");
    }

    // Метод для кнопки "Выход"
    public void ExitGame()
    {
        // Открыть окно подтверждения выхода
        ConfirmationDialog.Instance.Show();
    }
}

