using UnityEngine;
public class singleton : MonoBehaviour
{
    private static singleton instance = null;
    private  string text;
    public static singleton Ýnstance
    {
        get
        {
            if (instance == null)
            {
                instance = new GameObject("singleton").AddComponent<singleton>();
            }
            return instance;
        }

    }
    private void OnEnable()
    {
        //instance = this;
        text = "hello";
    }
    public  string print()
    {
        return text;
    }



}
