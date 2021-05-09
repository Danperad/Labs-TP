using System;

namespace lab_6
{
    public class Crypto
    {
        private static char[] _chars =
        {
            'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У',
            'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я'
        };

        public static bool Check(string text)
        {
            bool key = false;
            for (int i = 0; i < text.Length; i++)
            {
                char charr = Convert.ToChar(text.Substring(i, 1));
                for (int j = 0; j < _chars.Length; j++)
                {
                    if (charr == _chars[j])
                    {
                        key = true;
                        break;
                    }
                }

                if (!key) break;
            }

            return key;
        }

        public static string Crypt(string text, string key)
        {
            string s = "";
            int num_key = 0;
            string[] texts = text.Split('_');
            for (int i = 0; i < texts.Length; i++)
            {
                string v = Cryptt(texts[i], ref key, ref num_key);
                if (v == "")
                {
                    return "";
                }

                s += v;
                if (i != texts.Length - 1) s += "_";
            }

            return s;
        }

        private static string Cryptt(string text, ref string key, ref int num_key)
        {
            string s = "";
            if (!Check(text)) return s;

            for (int i = 0; i < text.Length; i++)
            {
                int j = Array.IndexOf(_chars, Convert.ToChar(key.Substring(num_key, 1)));
                int k = Array.IndexOf(_chars, Convert.ToChar(text.Substring(i, 1)));
                j = (j + k) % _chars.Length;
                s += _chars[j];
                num_key++;
                if (num_key == key.Length) num_key = 0;
            }

            return s;
        }

        public static string DeCrypt(string text, string key)
        {
            string s = "";
            int num_key = 0;
            string[] texts = text.Split('_');
            for (int i = 0; i < texts.Length; i++)
            {
                string v = DeCryptt(texts[i], ref key, ref num_key);
                if (v == "")
                {
                    return "";
                }

                s += v;
                if (i != texts.Length - 1) s += "_";
            }

            return s;
        }

        private static string DeCryptt(string text, ref string key, ref int num_key)
        {
            string s = "";
            if (!Check(text)) return s;

            for (int i = 0; i < text.Length; i++)
            {
                int j = Array.IndexOf(_chars, Convert.ToChar(key.Substring(num_key, 1)));
                int k = Array.IndexOf(_chars, Convert.ToChar(text.Substring(i, 1)));
                while (j > 0)
                {
                    k--;
                    if (k < 0) k = _chars.Length - 1;
                    j--;
                }

                s += _chars[k];
                num_key++;
                if (num_key == key.Length) num_key = 0;
            }

            return s;
        }
    }
}