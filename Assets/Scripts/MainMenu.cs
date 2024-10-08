using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // ����� ��� ������ "����� ����"
    public void StartNewGame()
    {
        // ������� �� ����� ��������
        SceneManager.LoadScene("GameplayScene");
    }

    // ����� ��� ������ "� ���������"
    public void OpenAbout()
    {
        // ������� �� ����� � ��������� ���������
        SceneManager.LoadScene("AboutScene");
    }

    // ����� ��� ������ "�����"
    public void ExitGame()
    {
        // ������� ���� ������������� ������
        ConfirmationDialog.Instance.Show();
    }
}

