using UnityEngine;

[CreateAssetMenu]
public class UseableStats : ScriptableObject
{
    [Header("LAYERS")]
    [Tooltip("Set this to the layer your player is on")]
    public LayerMask PlayerLayer;
    public LayerMask GroundLayer;

    [Header("Walk")]
    public float WalkSpeed = 14f;
    public float GroundAcceleration = 120f;
    public float AirAcceleration = 60f;

    [Header("Jump")]
    public float JumpHeight = 5;
    public int MaxAirJump = 0;
    public float JumpCutOff = 0.5f;

    public float CoyoteTime = 0.15f;
    public float BufferJump = 0.2f;

    [Header("Wall")]
    public float wallSlideSpeed = 1000f;

    public float wallJumpForce = 15f;
    [Header("Dash")]
    public float dashSpeed = 1f;
    public float dashDuration = 0.2f;
    public float dashCooldown = 1f;
}
