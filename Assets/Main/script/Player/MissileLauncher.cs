using UnityEngine;

public class MissileLauncher : MonoBehaviour
{
    public GameObject missilePrefab;

    public Transform firePoint;

    public float missilePower = 1200f;

    private Vector2 startTouch;

    private bool canShoot = true;

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            // タッチ開始
            if (touch.phase == TouchPhase.Began)
            {
                startTouch = touch.position;
            }

            // フリック終了
            if (touch.phase == TouchPhase.Ended)
            {
                if (!canShoot) return;

                Vector2 endTouch = touch.position;

                Vector2 dir = (endTouch - startTouch).normalized;

                Shoot(dir);
            }
        }
    }

    void Shoot(Vector2 dir)
    {
        canShoot = false;

        GameObject missile =
            Instantiate(missilePrefab, firePoint.position, Quaternion.identity);

        Rigidbody2D rb = missile.GetComponent<Rigidbody2D>();

        rb.linearVelocity = dir * missilePower;
    }

    // ミサイル消えたら再発射可能
    public void Reload()
    {
        canShoot = true;
    }
}