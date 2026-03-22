using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    [SerializeField] float maxY = 2.3f;
    [SerializeField] float minY = -2.3f;
    GameObject obstacle;
    public GameObject obstaclePrefab;
    public float spawnX = 10f;

    public float speedObstacle = 2f;
    public float timeRun = 0.1f;

    private void Start()
    {
        SpawnObstacle();
    }

    void Update()
    {
        speedObstacle += timeRun * Time.deltaTime;
        if (obstacle.transform.position.x <= 0)
        {
            SpawnObstacle();
        }
    }

    void SpawnObstacle()
    {
        obstacle = Instantiate(obstaclePrefab, new Vector3(spawnX, Random.Range(minY, maxY), 0), Quaternion.identity);
    }


}
