using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearablePiece : MonoBehaviour
{
    public AnimationClip clearAnimation;
    //public AnimationClip happyDance;

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

    public virtual void Clear()
    {
        piece.GridRef.level.OnPieceCleared(piece);
        isBeingCleared = true;
        StartCoroutine(ClearCoroutine());
    }

    private IEnumerator ClearCoroutine()
    {
        Animator animator = GetComponent<Animator>();

        if (animator)
        {
            animator.Play(clearAnimation.name);
            //animator.Play(happyDance.name);

            yield return new WaitForSeconds(clearAnimation.length);
            //yield return new WaitForSeconds(happyDance.length);

            Destroy(gameObject);
        }
    }




}
