using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Flag : MonoBehaviour
{
    public GameObject clearImage;
    public GameObject nextButton;
    public GameObject exitButton;
    public bool isCleared = false;
    void Start()
    {
        // �ʱ⿡�� UI ��Ȱ��ȭ
        clearImage.SetActive(false);
        nextButton.SetActive(false);
        exitButton.SetActive(false);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !isCleared)
        {
            isCleared = true;
            ShowClearUI();
        }
    }

    void ShowClearUI()
    {
        clearImage.SetActive(true);
        nextButton.SetActive(true);
        exitButton.SetActive(true);
    }
}