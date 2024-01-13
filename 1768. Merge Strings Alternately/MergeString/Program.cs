
var word1 = "abc";
var word2 = "def";
var result = MergeAlternately(word1, word2);
Console.WriteLine(result);

string MergeAlternately(string word1, string word2) {
    if(string.IsNullOrEmpty(word1)){
        return word2;
    }
    if(string.IsNullOrEmpty(word2)){
        return word1;
    }
    string result = "";
    var minLength = word1.Length > word2.Length ? word2.Length : word1.Length;
    for(int i = 0; i< minLength; i++) {
        result = result + word1[i] + word2[i];
    }
    if(word1.Length > minLength) {
        for(int i = minLength; i < word1.Length; i++ ){
            result += word1[i];
        }
    }
    else {
        for(int i = minLength; i < word2.Length; i++ ){
            result += word2[i];
        }
    }
    return result;
}