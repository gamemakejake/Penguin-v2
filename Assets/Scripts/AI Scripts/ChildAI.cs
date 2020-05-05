using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ChildAI : MonoBehaviour
{
    public Person person;
    public NavMeshAgent agent;
    public List<Transform> viewpoints;
    public List<Transform> spots;
    public IntReference dissatisfaction;
    public IntReference lowDissatisfaction;
    public IntReference highDissatisfaction;
    float timer = 10;
    // Start is called before the first frame update
    void Start()
    {
        if(dissatisfaction.Value < highDissatisfaction.Value)
        {
            int rand = Random.Range(0, viewpoints.Count);
            agent.SetDestination(viewpoints[rand].position);
        }
    }

    // Update is called once per frame
    void Update()
    {
        timer -= 1 * Time.deltaTime;
        if (dissatisfaction.Value > highDissatisfaction.Value && timer <= 0)
        {
            int random = Random.Range(0, spots.Count + 1);
            for (int i = 0; i < spots.Count; i++)
            {
                if (random == i)
                {
                    agent.SetDestination(spots[i].position);
                }
                person.atGate = false;
                timer = 10;
            }
        }
        if (dissatisfaction.Value > lowDissatisfaction.Value && dissatisfaction.Value < highDissatisfaction.Value && timer <= 0)
        {
            int r = Random.Range(0, 2);
            if (r == 1)
            {
                int random = Random.Range(0, spots.Count + 1);
                for (int i = 0; i < spots.Count; i++)
                {
                    if(random == i)
                    {
                        agent.SetDestination(spots[i].position);
                    }
                
                }
                person.atGate = false;
                timer = 10;
            }
            else
            {
                int rand = Random.Range(0, viewpoints.Count);
                agent.SetDestination(viewpoints[rand].position);
            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "ViewPoint")
        {
            person.atGate = true;
        }
    }
}
