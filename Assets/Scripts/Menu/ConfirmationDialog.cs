using UnityEngine;

public class ConfirmationDialog : MonoBehaviour
{
    public static ConfirmationDialog Instance;

    public GameObject dialogUI;

    private void Awake()
    {
        // Singleton для удобного доступа к диалогу
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Показать диалоговое окно
    public void Show()
    {
        dialogUI.SetActive(true);
    }

    // Спрятать диалоговое окно
    public void Hide()
    {
        dialogUI.SetActive(false);
    }

    // Метод для кнопки "Выйти"
    public void ConfirmExit()
    {
        Application.Quit();
    }

    // Метод для кнопки "Остаться"
    public void CancelExit()
    {
        Hide();
    }
}

