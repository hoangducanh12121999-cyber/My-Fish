using UnityEngine;

public class ObstacleMove : MonoBehaviour
{
    
    ObstacleManager obstacleManager;
    
    private void Start()
    {
        obstacleManager = FindAnyObjectByType<ObstacleManager>();
    }


    // Update is called once per frame
    void Update()
    {
        Vector3 pos;
        pos = Vector3.left * obstacleManager.speedObstacle * Time.deltaTime;
        transform.Translate(pos);
        if (transform.position.x <= - obstacleManager.spawnX)
        {
            Destroy(gameObject);
        }
    }
}
