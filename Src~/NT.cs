using UnityEngine;
using System.Diagnostics;


public class NT {

    [Conditional("DEVELOPMENT_BUILD"), Conditional("UNITY_EDITOR"), Conditional("NT_LOGS_ENABLE")]
    public static void Log(string message) {
        UnityEngine.Debug.Log(message);
    }

    [Conditional("DEVELOPMENT_BUILD"), Conditional("UNITY_EDITOR"), Conditional("NT_LOGS_ENABLE")]
    public static void Log(string message, Object context) {
        UnityEngine.Debug.Log(message, context);
    }

    [Conditional("DEVELOPMENT_BUILD"), Conditional("UNITY_EDITOR"), Conditional("NT_LOGS_ENABLE")]
    public static void LogWarning(string message) {
        UnityEngine.Debug.LogWarning(message);
    }

    [Conditional("DEVELOPMENT_BUILD"), Conditional("UNITY_EDITOR"), Conditional("NT_LOGS_ENABLE")]
    public static void LogWarning(string message, Object context) {
        UnityEngine.Debug.LogWarning(message, context);
    }

    [Conditional("DEVELOPMENT_BUILD"), Conditional("UNITY_EDITOR"), Conditional("NT_LOGS_ENABLE")]
    public static void LogError(string message) {
        UnityEngine.Debug.LogError(message);
    }

    [Conditional("DEVELOPMENT_BUILD"), Conditional("UNITY_EDITOR"), Conditional("NT_LOGS_ENABLE")]
    public static void LogError(string message, Object context) {
        UnityEngine.Debug.LogError(message, context);
    }

}
