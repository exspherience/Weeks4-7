using UnityEngine;

public class ShowReact : MonoBehaviour
{
    public Canvas npcReaction;
    public SpriteRenderer player;
    float distanceThreshold = 3f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, player.transform.position) < distanceThreshold)
        {
            npcReaction.enabled = true;
        }
        else npcReaction.enabled = false;
    }
}
