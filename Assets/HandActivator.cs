using UnityEngine;

public class HandModelActivator : MonoBehaviour
{
    public GameObject handModel; // 손 모델 오브젝트

    void Start()
    {
        if (handModel != null)
        {
            handModel.SetActive(true); // 강제로 활성화
        }
    }
}
