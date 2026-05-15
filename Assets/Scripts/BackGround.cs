using UnityEngine;

public class BackGround : MonoBehaviour
{
    private Renderer backGround;
    private float speedBackGround;
    [SerializeField] private float scaleFactor = 0.005f;
    private float offsetX;
    private ObstacleManager obstacleManager;

    private void Awake()
    {
        backGround = GetComponentInChildren<Renderer>();
        obstacleManager = FindAnyObjectByType<ObstacleManager>();
    }


    private void Update()
    {
        if (backGround != null)
        {
            speedBackGround = obstacleManager.speedObstacle;
            offsetX += speedBackGround * Time.deltaTime * scaleFactor;
            backGround.material.mainTextureOffset = new Vector2 (offsetX % 1, backGround.material.mainTextureOffset.y);
        }
    }
}
