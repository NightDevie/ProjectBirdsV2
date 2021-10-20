using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Milestones
{
    private int nextMilestone;

    private List<int> milestoneNumber = new List<int>();

    public void CheckMilestone(int score)
    {
        if (score >= milestoneNumber[nextMilestone])
        {
            CaseMilestone();
        }
    }

    private void CaseMilestone()
    {
        switch (nextMilestone)
        {
            case 1:

                break;
            case 2:

                break;
        }
    }
}
