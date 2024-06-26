using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    void Update()
    {
        // 매 프레임마다 R 키가 눌렸는지 확인
        if (Input.GetKeyDown(KeyCode.R))
        {
            // 현재 활성화된 씬을 다시 로드
            Scene currentScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(currentScene.name);
        }
        
        // 매 프레임마다 Q 키가 눌렸는지 확인
        if (Input.GetKeyDown(KeyCode.Q))
        {
            // 메인메뉴로
            SceneManager.LoadScene("Main");
        }
        // 마우스 왼쪽 버튼이 클릭되었을 때
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 rayOrigin = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(rayOrigin, Vector2.zero);

            // Ray가 Collider와 충돌했는지 확인
            if (hit.collider != null)
            {
                Debug.Log("딸깍");
                // 충돌한 오브젝트의 태그 확인
                if (hit.collider.CompareTag("Next"))
                {
                    // 다음 씬으로 이동하는 함수 호출
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                }
                else if (hit.collider.CompareTag("Exit"))
                {
                    // 메뉴로 이동하는 함수 호출
                    SceneManager.LoadScene("Main");
                }
            }
        }
    }
}