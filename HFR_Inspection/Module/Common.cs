namespace Haewon.Module
{
    public class Common
    {
        #region ENUM
        public enum Display_Menu
        {
            Process,
            Recipe,
            Vision,
            Motion,
            IO,
            Log
        }

        public enum OK_NG
        {
            OK,
            NG
        }

        public enum Camera
        {
            Cam1,
            Cam2
        }
        #endregion

        #region Function

        public static string Left(string Text, int TextLenth)
        {
            string ConvertText;
            if (Text.Length < TextLenth)
            {
                TextLenth = Text.Length;
            }
            ConvertText = Text.Substring(0, TextLenth);
            return ConvertText;
        }

        public static string Right(string Text, int TextLenth)
        {
            string ConvertText;
            if (Text.Length < TextLenth)
            {
                TextLenth = Text.Length;
            }
            ConvertText = Text.Substring(Text.Length - TextLenth, TextLenth);
            return ConvertText;
        }

        public static string Mid(string Text, int Startint, int Endint)
        {
            string ConvertText;
            if (Startint < Text.Length || Endint < Text.Length)
            {
                ConvertText = Text.Substring(Startint, Endint);
                return ConvertText;
            }
            else
                return Text;
        }

        #endregion
    }
}
