using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace DS{
    public class StringUtils{
        public static int countVowels(String str){
            int count =0;
            var vowels = "aeiou";
            if(str!=null)
            foreach(var c in str.ToLower()){
                if(vowels.Contains(c))
                    count++;
            }
            return count;
        }
        public static String reverseString(String str){
             var reverse = new StringBuilder();
             if(str!=null)
             for(int i=str.Length-1;i>=0;i--){
                reverse.Append(str[i]);
             }
            return reverse.ToString();
        }
        public static String reverseWords(String sentence){
            if(sentence==null) return "";
            var words = sentence.Split(' ').ToList();
            words.Reverse();
            return String.Join(" ",words);
        }
        public static Boolean areRotations(String str1,String str2){
            if(str1==null||str2==null) return false;
            return (str1.Length == str2.Length) && (str1+str1).Contains(str2);
        }
        public static String removeDuplicates(String str){
            if(str == null) return "";
            var s = new HashSet<Char>();
            var sb = new StringBuilder();
            foreach(var c in str){
                if(!s.Contains(c)){
                    s.Add(c);
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }
        public static char getMaxOccuringChar(String str){
            if(str == null || str == "") return char.MinValue;
            var hs = new System.Collections.Hashtable();
            foreach(var c in str){
                if(hs.Contains(c))
                    hs[c] = 1+(int)hs[c];
                else
                    hs.Add(c,1);
            }
            var keys = hs.Keys;
            var maxChar=' ';
            var freq=0;
            foreach(var key in keys){
                if(freq<(int)hs[key]){
                    freq=(int)hs[key];
                    maxChar = (char)key;
                }
            }
            return maxChar;
        }
        public static String capitalize (String sentence){
            // TextInfo info = CultureInfo.CurrentCulture.TextInfo;
            // return info.ToTitleCase(sentence);
            var words = sentence.Trim().Split(" ");
            for(int i=0; i<words.Length;i++){
                if(words[i] == "") continue;
                words[i] = words[i].Substring(0,1).ToUpper()+words[i].Substring(1).ToLower();
            }
            return String.Join(" ",words);
        }
        public static Boolean AreAnagrams (String str1, String str2){
            if(str1 == null || str2 == null || str1.Length != str2.Length) return false;
            str1 = str1.ToLower();
            str2 = str2.ToLower();
            foreach(var c in str2){
                if(!str1.Contains(c))
                    return false;
            }
            return true;
        }
        public static Boolean IsPalindrom(String word){
            if(word == null) return false;
            var rev = String.Join("",word.Reverse());
            return word.Equals(rev);
            // for(int i=0; i<word.Length;i++){
            //     if(!word[i].Equals(word[word.Length-i-1]))
            //         return false;
            // }
            // return true;
        }
    }
}