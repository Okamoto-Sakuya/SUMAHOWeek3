using UnityEngine;

public class Meteor : MonoBehaviour
{
    public float fallSpeed = 200f;

    private RectTransform rectTransform;

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    void Update()
    {
        rectTransform.anchoredPosition +=
            Vector2.down * fallSpeed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // 地面
        if (collision.CompareTag("Ground"))
        {
            GameManager.instance.MeteorLanded();

            Destroy(gameObject);
        }

        // ミサイル
        if (collision.CompareTag("Missile"))
        {
            GameManager.instance.AddScore(100);

            Destroy(collision.gameObject);

            Destroy(gameObject);
        }
    }
}