using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    void Update()
    {
        // �� �����Ӹ��� R Ű�� ���ȴ��� Ȯ��
        if (Input.GetKeyDown(KeyCode.R))
        {
            // ���� Ȱ��ȭ�� ���� �ٽ� �ε�
            Scene currentScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(currentScene.name);
        }
        
        // �� �����Ӹ��� Q Ű�� ���ȴ��� Ȯ��
        if (Input.GetKeyDown(KeyCode.Q))
        {
            // ���θ޴���
            SceneManager.LoadScene("Main");
        }
        // ���콺 ���� ��ư�� Ŭ���Ǿ��� ��
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 rayOrigin = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(rayOrigin, Vector2.zero);

            // Ray�� Collider�� �浹�ߴ��� Ȯ��
            if (hit.collider != null)
            {
                Debug.Log("����");
                // �浹�� ������Ʈ�� �±� Ȯ��
                if (hit.collider.CompareTag("Next"))
                {
                    // ���� ������ �̵��ϴ� �Լ� ȣ��
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                }
                else if (hit.collider.CompareTag("Exit"))
                {
                    // �޴��� �̵��ϴ� �Լ� ȣ��
                    SceneManager.LoadScene("Main");
                }
            }
        }
    }
}