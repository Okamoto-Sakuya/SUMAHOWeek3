//using UnityEngine;

//public class EnemyUI : MonoBehaviour
//{
//    public float fallSpeed = 200f;
//    public float deleteY = -600f; // Ç±Ç±Ç‹Ç≈çsÇ¡ÇΩÇÁè¡Ç¶ÇÈ

//    RectTransform rect;
//    RectTransform player;

//    void Awake()
//    {
//        rect = GetComponent<RectTransform>();

//        GameObject p = GameObject.FindGameObjectWithTag("Player");
//        if (p != null)
//        {
//            player = p.GetComponent<RectTransform>();
//        }
//    }

//    void Update()
//    {
//        rect.anchoredPosition += Vector2.down * fallSpeed * Time.deltaTime;

//        CheckHit();
//        CheckDelete();
//    }

//    void CheckHit()
//    {
//        if (player == null) return;

//        float distance = Vector2.Distance(
//            rect.anchoredPosition,
//            player.anchoredPosition
//        );

//        if (distance < 60f)
//        {
//            GameManager.Instance.GameOver();
//        }
//    }

//    void CheckDelete()
//    {
//        if (rect.anchoredPosition.y <= deleteY)
//        {
//            GameManager.Instance.AddScore(1);
//            Destroy(gameObject);
//        }
//    }
//}