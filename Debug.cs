using System;

/// <summary>
/// Methods of this class are called only if "LOGS_ENABLED" define is added to Scripting Define Symbols in Player Settings on Unity.
/// </summary>
public sealed class Debug
{
    private const string LOGS_ENABLED = "LOGS_ENABLED";
    private const string UNITY_ASSERTIONS = "UNITY_ASSERTIONS";
    private const string UNITY_EDITOR = "UNITY_EDITOR";
}