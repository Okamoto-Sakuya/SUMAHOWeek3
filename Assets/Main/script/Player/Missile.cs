using UnityEngine;

public class Missile : MonoBehaviour
{
    public float lifeTime = 3f;

    void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    private void OnDestroy()
    {
        MissileLauncher launcher =
            FindFirstObjectByType<MissileLauncher>();

        if (launcher != null)
        {
            launcher.Reload();
        }
    }
}