using System.Diagnostics;

/// <summary>
/// Methods of this class are called only if "LOGS_ENABLED" define is added to Scripting Define Symbols in Player Settings on Unity.
/// </summary>
public sealed class Debug
{
    private const string LOGS_ENABLED = "LOGS_ENABLED";
    private const string UNITY_ASSERTIONS = "UNITY_ASSERTIONS";
    private const string UNITY_EDITOR = "UNITY_EDITOR";

    /// <summary>
    /// Assert a condition and logs an error message to the Unity console on failure.
    /// </summary>
    /// <param name="condition">Condition you expect to be true.</param>
    [Conditional(LOGS_ENABLED), Conditional(UNITY_ASSERTIONS), Conditional(UNITY_EDITOR)]
    public static void Assert(bool condition)
    {
        UnityEngine.Debug.Assert(condition);
    }

    /// <summary>
    /// Assert a condition and logs an error message to the Unity console on failure.
    /// </summary>
    /// <param name="condition">Condition you expect to be true.</param>
    /// <param name="message">String or object to be converted to string representation for display.</param>
    [Conditional(LOGS_ENABLED), Conditional(UNITY_ASSERTIONS), Conditional(UNITY_EDITOR)]
    public static void Assert(bool condition, string message)
    {
        UnityEngine.Debug.Assert(condition, message);
    }

    /// <summary>
    /// Assert a condition and logs an error message to the Unity console on failure.
    /// </summary>
    /// <param name="condition">Condition you expect to be true.</param>
    /// <param name="message">Object to be converted to string representation for display.</param>
    [Conditional(LOGS_ENABLED), Conditional(UNITY_ASSERTIONS), Conditional(UNITY_EDITOR)]
    public static void Assert(bool condition, object message)
    {
        UnityEngine.Debug.Assert(condition, message);
    }

    /// <summary>
    /// Assert a condition and logs an error message to the Unity console on failure.
    /// </summary>
    /// <param name="condition">Condition you expect to be true.</param>
    /// <param name="context">Object to which the message applies.</param>
    [Conditional(LOGS_ENABLED), Conditional(UNITY_ASSERTIONS), Conditional(UNITY_EDITOR)]
    public static void Assert(bool condition, UnityEngine.Object context)
    {
        UnityEngine.Debug.Assert(condition, context);
    }

    /// <summary>
    /// Assert a condition and logs an error message to the Unity console on failure.
    /// </summary>
    /// <param name="condition">Condition you expect to be true.</param>
    /// <param name="message">String or object to be converted to string representation for display.</param>
    /// <param name="context">Object to which the message applies.</param>
    [Conditional(LOGS_ENABLED), Conditional(UNITY_ASSERTIONS), Conditional(UNITY_EDITOR)]
    public static void Assert(bool condition, string message, UnityEngine.Object context)
    {
        UnityEngine.Debug.Assert(condition, message, context);
    }

    /// <summary>
    /// Assert a condition and logs an error message to the Unity console on failure.
    /// </summary>
    /// <param name="condition">Condition you expect to be true.</param>
    /// <param name="message">String or object to be converted to string representation for display.</param>
    /// <param name="context">Object to which the message applies.</param>
    [Conditional(LOGS_ENABLED), Conditional(UNITY_ASSERTIONS), Conditional(UNITY_EDITOR)]
    public static void Assert(bool condition, object message, UnityEngine.Object context)
    {
        UnityEngine.Debug.Assert(condition, message, context);
    }

    /// <summary>
    /// Assert a condition and logs a formatted error message to the Unity console on failure.
    /// </summary>
    /// <param name="condition">Condition you expect to be true.</param>
    /// <param name="format">A composite format string.</param>
    /// <param name="args">Format arguments.</param>
    [Conditional(LOGS_ENABLED), Conditional(UNITY_ASSERTIONS), Conditional(UNITY_EDITOR)]
    public static void AssertFormat(bool condition, string format, params object[] args)
    {
        UnityEngine.Debug.AssertFormat(condition, format, args);
    }

    /// <summary>
    /// Assert a condition and logs a formatted error message to the Unity console on failure.
    /// </summary>
    /// <param name="condition">Condition you expect to be true.</param>
    /// <param name="context">Object to which the message applies.</param>
    /// <param name="format">A composite format string.</param>
    /// <param name="args">Format arguments.</param>
    [Conditional(LOGS_ENABLED), Conditional(UNITY_ASSERTIONS), Conditional(UNITY_EDITOR)]
    public static void AssertFormat(bool condition, UnityEngine.Object context, string format, params object[] args)
    {
        UnityEngine.Debug.AssertFormat(condition, context, format, args);
    }
}