using UnityEngine;

public class ConfirmationDialog : MonoBehaviour
{
    public static ConfirmationDialog Instance;

    public GameObject dialogUI;

    private void Awake()
    {
        // Singleton ��� �������� ������� � �������
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // �������� ���������� ����
    public void Show()
    {
        dialogUI.SetActive(true);
    }

    // �������� ���������� ����
    public void Hide()
    {
        dialogUI.SetActive(false);
    }

    // ����� ��� ������ "�����"
    public void ConfirmExit()
    {
        Application.Quit();
    }

    // ����� ��� ������ "��������"
    public void CancelExit()
    {
        Hide();
    }
}

