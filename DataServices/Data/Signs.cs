using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace DataServices.Data
{
    public static class Signs
    {
        public static char[] Letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l',
                                         'm', 'n', 'o', 'u', 'p', 'r', 's', 't', 'w', 'x', 'y', 'z'};

        public static char[] PolishLetters = { 'ą', 'ć', 'ę', 'ł', 'ń', 'ó', 'ś', 'ź', 'ż' };

        public static char[] SpecialSigns = {'!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '_',
                                             '=', '+', ',', '<', '.', '>', '/', '?', ';', ':', '"', '\'',
                                             '[', '{', ']', '}', '\\', '|'};
    }
}
