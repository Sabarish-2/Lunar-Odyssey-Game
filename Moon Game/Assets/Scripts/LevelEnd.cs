
using UnityEngine;

public class LevelEnd : MonoBehaviour
{
    public GameManager GameManager;

    void OnTriggerEnter()
    {
        GameManager.LevelEnd();
    }

}
