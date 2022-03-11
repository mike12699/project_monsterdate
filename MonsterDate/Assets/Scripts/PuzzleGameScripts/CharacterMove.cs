using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    public AnimationClip happyAnimation;

    private bool isBeingCleared = false;

    public bool IsBeingCleared
    {
        get { return isBeingCleared; }
    }

    //Is protected because this class will be extended later.
    protected GamePiece piece;

    void Awake()
    {
        piece = GetComponent<GamePiece>();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Clear()
    {
        isBeingCleared = true;
        StartCoroutine(ClearCoroutine());
    }

    private IEnumerator ClearCoroutine()
    {
        Animator animator = GetComponent<Animator>();

        if (animator)
        {
            animator.Play(happyAnimation.name);

            yield return new WaitForSeconds(happyAnimation.length);

            //Destroy(gameObject);
        }
    }




}
