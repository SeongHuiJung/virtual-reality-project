using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameGoal : MonoBehaviour
{
    public GameObject GoalPanel;
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Goal"))
        {
            Debug.Log("�� ���� �浹");
            if (gameObject.GetComponent<GameManager>().GetKeyNum() ==2)
            {
                Debug.Log("��");
                GoalPanel.gameObject.SetActive(true);
            }
        }
    }
}
