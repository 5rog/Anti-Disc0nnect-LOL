using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MelonLoader;
using VRC;
using static VRC.SDKBase.VRC_EventHandler;
using Harmony;
using System.Reflection;
using TriG55wag = VRC_EventDispatcherRFC;
namespace Anti_DisconneCt_Again_Lol
{
    public class Class1 : MelonMod
    {
        static HarmonyMethod DaPatchLocal = new HarmonyMethod(typeof(Class1).GetMethod("TriggeREvent5l0l", BindingFlags.Static | BindingFlags.NonPublic));

        static string TriggErEvenT5Method = "Method_Public_Void_Player_VrcEvent_VrcBroadcastType_Int32_Single_0";

        static void PatChtri5Ger()
        {
            HarmonyInstance.Create("tri55Er").Patch(typeof(TriG55wag).GetMethod(TriggErEvenT5Method), DaPatchLocal, null);
        }

        public override void OnApplicationStart() { PatChtri5Ger(); s5wag.Write("Successfully Loaded..", ConsoleColor.Blue); }


        private static bool TriggeREvent5l0l(Player __0, VrcEvent __1, VrcBroadcastType __2, int __3)
        {
            try // i Keep hearinG l0l "iM gettiNg dc by unusual client behavi0r.. thi5 cachiNg expl0it iS really really 0ld idk y resurfacing.. Ph0toniAns #1"
            { // n0t  ignoRing L0cal  bC i truly h0pE u dont use thi5 exploit lol
                var Global = __2 == VrcBroadcastType.Always || __2 == VrcBroadcastType.AlwaysUnbuffered || __2 == VrcBroadcastType.AlwaysBufferOne || __2 == VrcBroadcastType.MasterBufferOne || __2 == VrcBroadcastType.MasterUnbuffered || __2 == VrcBroadcastType.OwnerBufferOne || __2 == VrcBroadcastType.Owner || __2 == VrcBroadcastType.OwnerBufferOne || __2 == VrcBroadcastType.OwnerUnbuffered
                    || __2 == VrcBroadcastType.Master; // unness
                if (Global)
                    if (__1.ParameterString.Length > 70 || __1.ParameterString.Contains("color") || __1.EventType == VrcEventType.AddHealth || __1.ParameterString.Contains("love") /* ;p lol */ || __1.ParameterString.Contains("()"))
                    {
                        s5wag.Write($"{__0.field_Private_VRCPlayerApi_0.displayName} Tried To Disconnect", ConsoleColor.Blue);
                        return false;
                    }
            }
            catch { }
            return true;
        }
    }

    public static class s5wag
    {
        public static void Write(string text, ConsoleColor col)
        {
            Console.ForegroundColor = col; Console.WriteLine($"[{System.DateTime.Now.Hour}:{System.DateTime.Now.Minute}:{System.DateTime.Now.Second}] [A-DC] {text}"); Console.ForegroundColor = col;
        }
    }

}
