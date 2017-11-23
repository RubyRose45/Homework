using UnityEngine;
using System.Collections;

public class Monster : MonoBehaviour 
{
	
    public enum State 
	{
        Crawl,
        Walk,
        Die,
        Run,
        Shoot,
        Reload,
        Prone,
        Switch,
    }

    public State state;

    IEnumerator CrawlState () 
	{
        Debug.Log("Crawl: Enter");
        while (state == State.Crawl)
		{
            yield return 0;
        }
        Debug.Log("Crawl: Exit");
        NextState();
    }

    IEnumerator WalkState () 
	{
        Debug.Log("Walk: Enter");
        while (state == State.Walk) 
		{
            yield return 0;
        }
        Debug.Log("Walk: Exit");
        NextState();
    }

    IEnumerator DieState () 
	{
        Debug.Log("Die: Enter");

        while (state == State.Die) 
		{
            yield return 0;
        }
        Debug.Log("Die: Exit");
    }

    IEnumerator RunState()
    {
        Debug.Log("Run: Enter");

        while (state == State.Run)
        {
            yield return 0;
        }
        Debug.Log("Run: Exit");
    }

    IEnumerator ShootState()
    {
        Debug.Log("Shoot: Enter");

        while (state == State.Shoot)
        {
            yield return 0;
        }
        Debug.Log("Shoot: Exit");
    }

    IEnumerator ReloadState()
    {
        Debug.Log("Reload: Enter");

        while (state == State.Reload)
        {
            yield return 0;
        }
        Debug.Log("Reload: Exit");
    }

    IEnumerator ProneState()
    {
        Debug.Log("Prone: Enter");

        while (state == State.Prone)
        {
            yield return 0;
        }
        Debug.Log("Prone: Exit");
    }

    IEnumerator SwitchState()
    {
        Debug.Log("Switch: Enter");

        while (state == State.Switch)
        {
            yield return 0;
        }
        Debug.Log("Switch: Exit");
    }

    void Start () 
	{
        NextState();
    }

    void NextState () 
	{
        string methodName = state.ToString() + "State";
        System.Reflection.MethodInfo info = GetType().GetMethod(methodName, System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
        StartCoroutine((IEnumerator)info.Invoke(this, null));
    }
}