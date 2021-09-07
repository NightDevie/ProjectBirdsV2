using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    private GameObject[] obstacles;
    [SerializeField] private GameObject obstaclesPrefab;
    [SerializeField] private float initialXPoolSpawn;
    [SerializeField] private float minObstacleYPos;
    [SerializeField] private float maxObstacleYPos;
    [SerializeField] private float repositionTime;
    [SerializeField] private float repositionXPos;
    [SerializeField] private int obstaclesPoolSize;
    private float timeSinceLastReposition;
    private int currentObstacle;

    // Start is called before the first frame update
    public void ObstaclePoolSpawn()
    {
        //Initialize the obstacles array collection.
        obstacles = new GameObject[obstaclesPoolSize];

        //Loop through the collection
        for (int i = 1; i < obstaclesPoolSize; i++)
        {
            //Spawn all* the obstacles and add them to the array
            obstacles[i] = Instantiate(obstaclesPrefab, new Vector2(initialXPoolSpawn, 0f), Quaternion.identity);
            initialXPoolSpawn++;
        }

        //*Spawn the first obstacle in the right position so it's more efficient
        obstacles[0] = Instantiate(obstaclesPrefab, new Vector2(repositionXPos, Random.Range(minObstacleYPos, maxObstacleYPos)), Quaternion.identity);
        currentObstacle++;

        timeSinceLastReposition = 0f;
    }

    public void ObstacleReposition()
    {
        timeSinceLastReposition += Time.deltaTime;

        if (timeSinceLastReposition >= repositionTime)
        {
            timeSinceLastReposition = 0f;

            obstacles[currentObstacle].transform.position = new Vector2(repositionXPos, Random.Range(minObstacleYPos, maxObstacleYPos));

            currentObstacle++;

            if (currentObstacle >= obstaclesPoolSize)
            {
                currentObstacle = 0;
            }
        }
    }
}
