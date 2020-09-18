using UnityEngine;

//목표 : 일정(생성) 시간에 한번씩 적을 생성한다.
//필요속성 : 생성시간, 적공장
public class EnemyManager : MonoBehaviour
{

    //필요속성 : 생성시간, 적공장

    float currentTime;
    float createTime;

    public float minTime = 1;
    public float maxTime = 5;
        
    public GameObject enemyFactory;
    // Start is called before the first frame update
    void Start()
    {
        createTime = UnityEngine.Random.Range(minTime, maxTime);
    }

    // Update is called once per frame
    void Update()
    {
        //목표 : 일정(생성) 시간에 한번씩 적을 생성한다.
                        
        //1. 시간이 흘렀으니까!!
        // -> 경과시간이 흘러가는것!.
        currentTime += Time.deltaTime;

        //2. 일정시간(생성) 됬으니까!
        if (currentTime > createTime)
        {
            //3. 적을 공장에서 생성해야 한다.
            GameObject enemy = Instantiate(enemyFactory);

            //4. 생성된 적을 배치한다.
            enemy.transform.position = transform.position;
            createTime = UnityEngine.Random.Range(minTime, maxTime);
            currentTime = 0;
        }

    }
}
