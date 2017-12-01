using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class Text {
    private static volatile Text M;
    private static object syncroot = new object();
    public static Text m
    {
        get {
            if (M == null) {
                lock (syncroot) {
                    if (M == null) {
                        M = new Text();
                    }
                }             
            }
            return M;   
        }
    }
    public int i = 100;
    public void Health() {
        Debug.Log("血量为 "+i);
    }
    public void changeHealth(int t) {
        i = t;
        Debug.Log("修改成功" + i);
    }
}