using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Enemy1;
    public GameObject Enemy2;
    public GameObject Enemy3;
    public int xPos;
    public int zPos;
    public int enemy1CountAmount;
    public int enemy2CountAmount;
    public int enemy3CountAmount;
    private int enemyCounter1 = 0;
    private int enemyCounter2 = 0;
    private int enemyCounter3 = 0;
    
    void Start()
    {
        StartCoroutine(EnemyDrop());
    }


    IEnumerator EnemyDrop()
    {
        while(enemyCounter1 < enemy1CountAmount)
        {
            xPos = Random.Range(1, 50);
            zPos = Random.Range(1, 50);
            Instantiate(Enemy1, new Vector3(xPos, 5, zPos), Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
            enemyCounter1 += 1;
        }
        while (enemyCounter2 < enemy2CountAmount)
        {
            xPos = Random.Range(1, 50);
            zPos = Random.Range(1, 50);
            Instantiate(Enemy2, new Vector3(xPos, 5, zPos), Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
            enemyCounter2 += 1;
        }
        while (enemyCounter3 < enemy3CountAmount)
        {
            xPos = Random.Range(1, 50);
            zPos = Random.Range(1, 50);
            Instantiate(Enemy3, new Vector3(xPos, 5, zPos), Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
            enemyCounter3 += 1;
        }
    }
}
