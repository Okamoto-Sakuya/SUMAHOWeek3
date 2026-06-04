using UnityEngine;

public class MissileLauncher : MonoBehaviour
{
    public GameObject missilePrefab;

    public Transform firePoint;

    [SerializeField] private float missilePower = 10f;

    private Vector2 startPos;

    private bool canShoot = true;

    void Update()
    {
        //========================
        // スマホ操作
        //========================

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            // タッチ開始
            if (touch.phase == TouchPhase.Began)
            {
                startPos = touch.position;
            }

            // タッチ終了
            if (touch.phase == TouchPhase.Ended)
            {
                if (!canShoot) return;

                Vector2 endPos = touch.position;

                Vector2 dir =
                    (endPos - startPos).normalized;

                Shoot(dir);
            }
        }

        //========================
        // マウス操作（テスト用）
        //========================

        if (Input.GetMouseButtonDown(0))
        {
            startPos = Input.mousePosition;
        }

        if (Input.GetMouseButtonUp(0))
        {
            if (!canShoot) return;

            Vector2 endPos = Input.mousePosition;

            Vector2 dir =
                (endPos - startPos).normalized;

            Shoot(dir);
        }
    }

    void Shoot(Vector2 dir)
    {
        canShoot = false;

        GameObject missile =
            Instantiate(
                missilePrefab,
                firePoint.position,
                Quaternion.identity
            );

        Rigidbody2D rb =
            missile.GetComponent<Rigidbody2D>();

        rb.linearVelocity = dir * missilePower;
    }

    // リロード
    public void Reload()
    {
        canShoot = true;
    }
}