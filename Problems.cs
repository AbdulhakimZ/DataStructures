using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace DS{
    public class Problems {
        public char firstNonRepeatedCharacter(string text){
            // var ht = new Dictionary<char,int>(); //you can use whether dictionary or hashtable
            var ht = new Hashtable();
            for(int i=0;i<text.Length;i++){
                if(ht.ContainsKey(text[i])){
                    ht[text[i]] = (int)ht[text[i]]+1;
                }else{
                    ht.Add(text[i],1);
                }
            }
            
            for(int i=0;i<text.Length;i++){
                if((int)ht[text[i]] == 1){
                    return (char)text[i];
                }
            }
            return Char.MinValue;
        }
        public char firstRepeatedCharacter(string text){
            var hs = new HashSet<char>();
            for(int i=0; i<text.Length;i++){
                if(hs.Contains(text[i]))
                    return text[i];
                hs.Add(text[i]);
            }
            return Char.MinValue;
        }
        public int[] removeDuplicate(int[] items){
            var hs = new HashSet<int>();
            foreach(var item in items){
                hs.Add(item);
            }
            return hs.ToArray();
        }
        public string LongestPalindrome(string s) {
        var longest = new StringBuilder();
        for(int i=0;i<s.Length;i++){
            var temp = new StringBuilder();
            temp.Append(s[i]);
            if(longest.Length < temp.Length){
                longest.Clear();
                longest.Append(temp.ToString());
            }
            
            for(int j=i+1; j<s.Length;j++){
                temp.Append(s[j]);
                if(IsPalindrome(temp)){
                    if(longest.Length < temp.Length){
                        longest.Clear();
                        longest.Append(temp.ToString());
                    }
                }
            }
        }
        return longest.ToString();
    }
    public bool IsPalindrome(StringBuilder sb){
        string s = sb.ToString();
        for(int i=0;i<s.Length;i++){
            if(s[i]!=s[s.Length-1-i]){
                return false;
            }
        }
        return true;
    }
    }
}