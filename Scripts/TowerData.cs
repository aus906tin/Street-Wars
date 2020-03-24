using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Generic;
public class TowerData : MonoBehaviour
{
    public List<TowerLevel> levels;
    private TowerLevel currentLevel;

    [System.Serializable]
    public class TowerLevel
    {
        public int cost;
        public GameObject visualization;
    }

    public TowerLevel CurrentLevel
    {
        //2
        get
        {
            return currentLevel;
        }
        //3
        set
        {
            currentLevel = value;
            int currentLevelIndex = levels.IndexOf(currentLevel);

            GameObject levelVisualization = levels[currentLevelIndex].visualization;
            for (int i = 0; i < levels.Count; i++)
            {
                if (levelVisualization != null)
                {
                    if (i == currentLevelIndex)
                    {
                        levels[i].visualization.SetActive(true);
                    }
                    else
                    {
                        levels[i].visualization.SetActive(false);
                    }
                }
            }
        }
    }
    void OnEnable()
    {
        CurrentLevel = levels[0];
    }
}