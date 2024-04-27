using UnityEngine;

public class Q06 : MonoBehaviour
{
    [SerializeField] int victories = 0;
    [SerializeField] int draws = 0;
    // Start is called before the first frame update
    void Start()
    {
        print("Pontos do time: " + CalculateTeamPoints(victories, draws));
    }

    int CalculateTeamPoints(int victories, int draws)
    {
        int points = (victories * 3) + draws;
        return points;
    }
}
