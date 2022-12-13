using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    private bool m_isOpen = false;
    private bool isInteract = true;
    private IEnumerator doorCoroutine;

    // �÷��̾ ���� �ݴ� ��
    public void InteractDoor(float rotTime = 0.8f)
    {
        if (!isInteract) return;
        if (m_isOpen) doorCoroutine = DoorCoroutine(false, rotTime);
        else doorCoroutine = DoorCoroutine(true, rotTime);
        if (doorCoroutine is not null) StopCoroutine(doorCoroutine);
        StartCoroutine(doorCoroutine);
        m_isOpen = !m_isOpen;
    }

    // Ʈ���ŷ� ���� ���� �÷��̾ Ǯ �� ����
    public void InteractDoor(bool isOpen, float rotTime = 0.8f)
    {
        isInteract = false;
        doorCoroutine = DoorCoroutine(isOpen, rotTime);
        if (doorCoroutine is not null) StopCoroutine(doorCoroutine);
        StartCoroutine(doorCoroutine);
        m_isOpen = !m_isOpen;
    }

    // Ư�� ������ ������ �÷��̾� ���� ���� ���� ��
    public void SetInteractable() => isInteract = true;

    private IEnumerator DoorCoroutine(bool isOpen, float rotTime)
    {
        float endTime;
        Quaternion curRot = transform.rotation;
        Vector3 targetVec;
        Quaternion targetRot;

        targetVec = transform.rotation.eulerAngles;
        if (isOpen) targetVec.y += 105f;
        else targetVec.y -= 105f;
        targetRot = Quaternion.Euler(targetVec);

        endTime = 0f;
        while (endTime < rotTime)
        {
            transform.rotation = Quaternion.Euler(Vector3.Lerp(curRot.eulerAngles, targetRot.eulerAngles, endTime / rotTime));
            endTime += Time.deltaTime;
            yield return null;
        }
    }
}
