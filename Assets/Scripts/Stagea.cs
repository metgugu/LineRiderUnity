using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stage1 : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 rayOrigin = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(rayOrigin, Vector2.zero);

            // Ray가 Collider와 충돌했는지 확인
            if (hit.collider != null)
            {
                // 충돌한 오브젝트의 태그 확인
                if (hit.collider.CompareTag("Stage1"))
                {
                    SceneManager.LoadScene("Stage1");
                }
                else if (hit.collider.CompareTag("Stage2"))
                {
                    SceneManager.LoadScene("Stage2");
                }
                else if (hit.collider.CompareTag("Stage3"))
                {
                    SceneManager.LoadScene("Stage3");
                }
                else if (hit.collider.CompareTag("Stage4"))
                {
                    SceneManager.LoadScene("Stage4");
                }
                else if (hit.collider.CompareTag("Stage5"))
                {
                    SceneManager.LoadScene("Stage5");
                }
                else if (hit.collider.CompareTag("Stage6"))
                {
                    SceneManager.LoadScene("Stage6");
                }
                else if (hit.collider.CompareTag("Stage7"))
                {
                    SceneManager.LoadScene("Stage7");
                }
                else if (hit.collider.CompareTag("Stage8"))
                {
                    SceneManager.LoadScene("Stage8");
                }
                else if (hit.collider.CompareTag("Stage9"))
                {
                    SceneManager.LoadScene("Stage9");
                }
                else if (hit.collider.CompareTag("Stage10"))
                {
                    SceneManager.LoadScene("StageEnd");
                }
            }
        }
    }
}
