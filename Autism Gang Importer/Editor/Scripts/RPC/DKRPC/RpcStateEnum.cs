namespace TGE_SDK
{
    public static class RpcStateInfo
    {
        public static string StateName(this RpcState state)
        {
            switch (state)
            {
                case RpcState.EDITMODE: return "𝑀𝑜𝒹𝒾𝒻𝓎𝒾𝓃𝑔";
                case RpcState.PLAYMODE: return "𝒯𝑒𝓈𝓉𝒾𝓃𝑔";
                default: return "If you see this Fuck off";
            }
        }
    }

        public enum RpcState
    {
        EDITMODE = 0,
        PLAYMODE = 1,
        UPLOADPANEL = 2
    }
}
