using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphanumericSequencerCore
{
    public class AlphanumericIncrement
    {
        public enum Mode
        {
            AlphaNumeric = 1,
            Alpha = 2,
            Numeric = 3
        }

        public static string Increment(string text, Mode mode)
        {
            var textArr = text.ToCharArray();

            // Add legal characters
            var charactersN = new List<char>();
            var charactersL = new List<char>();
            var charactersLm = new List<char>();

            if (mode == Mode.AlphaNumeric || mode == Mode.Numeric)
                for (char c = '0'; c <= '9'; c++)
                    charactersN.Add(c);

            if (mode == Mode.AlphaNumeric || mode == Mode.Alpha)
                for (char c = 'a'; c <= 'z'; c++)
                    charactersL.Add(c);

            if (mode == Mode.AlphaNumeric || mode == Mode.Alpha)
                for (char c = 'A'; c <= 'Z'; c++)
                    charactersLm.Add(c);

            // Loop from end to beginning
            for (int i = textArr.Length - 1; i >= 0; i--)
            {
                if (char.IsLetter(textArr[i]))
                {
                    if (char.IsUpper(textArr[i]))
                    {
                        if (textArr[i] == charactersLm.Last())
                        {
                            textArr[i] = charactersLm.First();
                        }
                        else
                        {
                            textArr[i] = charactersLm[charactersLm.IndexOf(textArr[i]) + 1];
                            break;
                        }
                    }
                    else
                    {
                        if (textArr[i] == charactersL.Last())
                        {
                            textArr[i] = charactersL.First();
                        }
                        else
                        {
                            textArr[i] = charactersL[charactersL.IndexOf(textArr[i]) + 1];
                            break;
                        }
                    }

                }
                if (char.IsNumber(textArr[i]))
                {
                    if (textArr[i] == charactersN.Last())
                    {
                        textArr[i] = charactersN.First();
                    }
                    else
                    {
                        textArr[i] = charactersN[charactersN.IndexOf(textArr[i]) + 1];
                        break;
                    }
                }
            }
            return new string(textArr);
        }
    }
}
