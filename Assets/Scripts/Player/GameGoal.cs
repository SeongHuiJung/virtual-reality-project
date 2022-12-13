using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameGoal : MonoBehaviour
{
    public GameObject GoalPanel;
    public GameObject GameOverPanel;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Goal"))
        {
            Debug.Log("�� ���� �浹");
            if (gameObject.GetComponent<GameManager>().GetKeyNum() ==4)
            {
                Debug.Log("��");
                GoalPanel.gameObject.SetActive(true);
            }
        }

        else if(collider.gameObject.CompareTag("Monster"))
        {
            Debug.Log("����");
            GameOverPanel.gameObject.SetActive(true);
        }
    }
}
