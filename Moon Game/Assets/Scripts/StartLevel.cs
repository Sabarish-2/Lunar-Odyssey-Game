
using UnityEngine;

public class StartLevel : MonoBehaviour
{
    public GameManager GameManager;

    public void OnStart()
    {
        GameManager.NextLevel();
    }

}
